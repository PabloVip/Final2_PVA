using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Final25_48782431Y_48848258F_29527260K.Clases;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioKits : Form
    {
        private List<Producto> _kits;

        public FormularioKits()
        {
            InitializeComponent();

            //CARGO LOS KITS AL COMBOBOX. Guardo la lista de kits al inicializar la ventana en _kits
            CargaComboKits();

            cbCatalogo.SelectedIndexChanged += cbCatalogo_SelectedIndexChanged;

        }

        private void CargaComboKits()
        {
            lblId.Text = string.Empty;
            lblCodigo.Text = string.Empty;
            lblDescripcion.Text = string.Empty;
            lblCategoria.Text = string.Empty;
            lblMarca.Text = string.Empty;
            lblPrecio.Text = string.Empty;

            cbCatalogo.Items.Clear();
            _kits = BaseDeDatos.LeerKits();
            cbCatalogo.Items.AddRange(_kits.Select(x => x.Codigo).ToArray());

            listView1.Items.Clear();
        }

        private void MuestraDatosDelKit(string codigoKit)
        {
            var productoSeleccionado = _kits.First(x => x.Codigo == codigoKit);
            lblId.Text = productoSeleccionado.Id.ToString();
            lblCodigo.Text = productoSeleccionado.Codigo;
            lblDescripcion.Text = productoSeleccionado.Descripcion;
            lblCategoria.Text = productoSeleccionado.Categoria;
            lblMarca.Text = productoSeleccionado.Marca;
            lblPrecio.Text = productoSeleccionado.Precio.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioKits_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código .productosTableAdapter.Fill(this.pAYAVISOLARDataSet.Productos);
            

        }

        //ARREGLAR
        private void cbCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kitSeleccionado = cbCatalogo.SelectedItem.ToString();
            MuestraDatosDelKit(kitSeleccionado);

            if (!string.IsNullOrWhiteSpace(kitSeleccionado))
            {
                // Consulto el Id del producto kit
                var idDelKit = _kits.First(x => x.Codigo == kitSeleccionado).Id;

                // Consulto los productos incluidos en el kit
                var productosDelKit = BaseDeDatos.LeerProductosDeUnKit(idDelKit);

                listView1.Items.Clear();

                // Si el kit no tiene productos, salimos
                if (!productosDelKit.Any()) 
                    return;
                
                foreach (var pk in productosDelKit)
                {
                    var item = new ListViewItem(pk.Id.ToString());
                    item.SubItems.Add(pk.Codigo);
                    item.SubItems.Add(pk.Descripcion);
                    item.SubItems.Add(pk.Categoria);
                    item.SubItems.Add(pk.Marca);
                    item.SubItems.Add(pk.Precio.ToString("C"));
                    item.SubItems.Add(pk.Cantidad.ToString("N2"));
                    listView1.Items.Add(item);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCatalogo.SelectedItem != null)
                {
                    var producto = _kits.First(x => x.Codigo == cbCatalogo.SelectedItem);
                    BaseDeDatos.EliminarKit(producto.Id);

                    CargaComboKits();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando kit: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCatalogo.SelectedItem != null && listView1.SelectedItems.Count == 1)
                {
                    var kitSeleccionado = (Producto)cbCatalogo.SelectedItem;
                    var filaSeleccionada = listView1.SelectedItems[0];
                    BaseDeDatos.EliminarProductoDeUnKit(kitSeleccionado.Id,
                        Int32.Parse(filaSeleccionada.SubItems[0].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando producto del kit: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            // Mostrar ventana para elegir un producto y obtener el código y la cantidad
            FormularioAniadirProducto fProducto = new FormularioAniadirProducto();

            string codigoProducto = null;
            decimal cantidad = 0;

            if (fProducto.ShowDialog() == DialogResult.OK)
            {
                codigoProducto = fProducto.codigoProducto;

                if (!decimal.TryParse(fProducto.cantidad, out cantidad))
                {
                    MessageBox.Show("Cantidad inválida");
                    return;
                }
            }
            else
            {
                return; // El usuario canceló el formulario
            }

            try
            {
                listView1.Clear();

                if (cbCatalogo.SelectedValue is string codigoKitSeleccionado)
                {
                    // Buscamos el ID del kit por su código
                    var idDelKit = _kits.First(x => x.Codigo == codigoKitSeleccionado).Id;

                    // Añadimos el producto al kit
                    BaseDeDatos.AñadirProductoAUnKit(idDelKit, codigoProducto, cantidad);

                    // Leemos los productos actualizados del kit
                    var productosDelKit = BaseDeDatos.LeerProductosDeUnKit(idDelKit);

                    listView1.Items.Clear();

                    if (!productosDelKit.Any())
                        return;

                    foreach (var pk in productosDelKit)
                    {
                        var item = new ListViewItem(pk.Id.ToString());
                        item.SubItems.Add(pk.Codigo);
                        item.SubItems.Add(pk.Descripcion);
                        item.SubItems.Add(pk.Categoria);
                        item.SubItems.Add(pk.Marca);
                        item.SubItems.Add(pk.Precio.ToString("C"));
                        item.SubItems.Add(pk.Cantidad.ToString("N2"));
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar ventana y pedir los datos de un producto que va a ser un kit. Todos los campos menos Id y EsKit
                var frmNuevoProducto = new FormularioNuevoProducto(true);

                if (frmNuevoProducto.ShowDialog() == DialogResult.OK)
                {
                    BaseDeDatos.GuardarKit(frmNuevoProducto.Producto);

                    // Recargamos el combobox con los kits
                    CargaComboKits();    

                    cbCatalogo.SelectedItem = frmNuevoProducto.Producto.Codigo;
                    MuestraDatosDelKit(frmNuevoProducto.Producto.Codigo);

                    listView1.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarKit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCatalogo.SelectedItem != null)
                {
                    var productoKit = _kits.First(x => x.Codigo == cbCatalogo.SelectedItem);

                    var frmNuevoProducto = new FormularioNuevoProducto(true, productoKit);
                    if (frmNuevoProducto.ShowDialog() == DialogResult.OK)
                    {
                        BaseDeDatos.ModificarProducto(frmNuevoProducto.Producto);

                        // Recargamos el combobox con los kits
                        CargaComboKits();

                        cbCatalogo.SelectedItem = frmNuevoProducto.Producto.Codigo;
                        MuestraDatosDelKit(frmNuevoProducto.Producto.Codigo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

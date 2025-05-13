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
            _kits = BaseDeDatos.LeerKits();

            // Al AddRange necesita un array en vez de una lista
            var codigos = _kits.Select(x => x.Codigo).ToArray();
            cbCatalogo.Items.AddRange(codigos);

            cbCatalogo.SelectedIndexChanged += cbCatalogo_SelectedIndexChanged;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioKits_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código .productosTableAdapter.Fill(this.pAYAVISOLARDataSet.Productos);
            

        }

        private void cbCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCatalogo.SelectedValue is string codigoKit)
            {
                // Consulto el Id del producto kit
                var idDelKit = _kits.First(x => x.Codigo == codigoKit).Id;

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
                    var productoSeleccionado = (Producto)cbCatalogo.SelectedItem;
                    BaseDeDatos.EliminarKit(productoSeleccionado.Id);
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
            // Mostrar ventana para elegir un producto y obtener el id    POR HACER

            
            try
            {
                listView1.Clear();

                if (cbCatalogo.SelectedValue is string codigoKit)
                {
                    // Consulto el Id del producto kit
                    var idDelKit = _kits.First(x => x.Codigo == codigoKit).Id;


                    // BaseDeDatos.AñadirProductoAUnKit(idDelKit, );  // Aqui hay que pasar el id del producto consultado arriba


                    // Consulto los productos incluidos en el kit para recargarlos
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
            catch (Exception ex)
            {
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Mostrar ventana y pedir los datos de un producto que va a ser un kit. Todos los camos menos Id y EsKit

            // BaseDeDatos.GuardarKit( producto );

            // Recargamos el combobox con los kits
            var codigos = _kits.Select(x => x.Codigo).ToArray();
            cbCatalogo.Items.AddRange(codigos);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

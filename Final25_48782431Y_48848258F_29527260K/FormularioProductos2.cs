using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Final25_48782431Y_48848258F_29527260K.Clases;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioProductos2 : Form
    {
        private List<Producto> _productos;
        public FormularioProductos2()
        {
            InitializeComponent();

            if (BaseDeDatos.UsuarioActivo.RollId != "ADMINISTRADOR")
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnNueva.Enabled = false;
            }
        }

        private void CargaProductos()
        {
            lvProductos.Items.Clear();
            if (BaseDeDatos.UsuarioActivo.RollId == "ADMINISTRADOR")
                _productos = BaseDeDatos.LeerProductos();
            else
                _productos = BaseDeDatos.LeerProductosYKits();

            foreach (var producto in _productos)
            {
                var item = new ListViewItem(producto.Id.ToString());
                item.SubItems.Add(producto.Codigo);
                item.SubItems.Add(producto.Descripcion);
                item.SubItems.Add(producto.Categoria);
                item.SubItems.Add(producto.Marca);
                item.SubItems.Add(producto.Precio.ToString());
                lvProductos.Items.Add(item);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormularioNuevoProducto(false);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    BaseDeDatos.GuardarProducto(form.Producto);
                    CargaProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creando el producto: " + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvProductos.SelectedItems.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione un producto");
                return;
            }

            try
            {
                if (MessageBox.Show("¿Quiere eliminar el producto?", "", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    var idProducto = lvProductos.SelectedItems[0].SubItems[0].Text;

                    if (BaseDeDatos.CompruebaProductoUtilizadoEnKit(int.Parse(idProducto)))
                    {
                        MessageBox.Show("Atención: no se puede eliminar el producto porque está en uso en algún kit",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BaseDeDatos.EliminarProducto(int.Parse(idProducto));
                    CargaProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando el producto: " + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvProductos.SelectedItems.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione un producto");
                return;
            }

            try
            {
                var producto = _productos.First(x => x.Id == int.Parse(lvProductos.SelectedItems[0].SubItems[0].Text));
                var form = new FormularioNuevoProducto(false, producto);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    BaseDeDatos.ModificarProducto(form.Producto);
                    CargaProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editando el producto: " + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormularioProductos2_Load(object sender, EventArgs e)
        {
            CargaProductos();
        }
    }
}

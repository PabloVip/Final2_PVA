using Final25_48782431Y_48848258F_29527260K.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class formEditarProducto : Form
    {
        private List<Producto> _productos;
        public formEditarProducto()
        {
            InitializeComponent();
            _productos = BaseDeDatos.LeerKits();

            foreach (var producto in _productos)
            {
                var item = new ListViewItem(producto.Id.ToString());
                item.SubItems.Add(producto.Codigo);
                item.SubItems.Add(producto.Descripcion);
                item.SubItems.Add(producto.Categoria);
                item.SubItems.Add(producto.Marca);
                item.SubItems.Add(producto.Precio.ToString("C"));

                lvProductos.Items.Add(item);
            }
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar ventana y pedir los datos de un producto. Todos los campos menos Id y EsKit
                var frmNuevoProducto = new FormularioNuevoProducto(false);

                if (frmNuevoProducto.ShowDialog() == DialogResult.OK)
                {
                    BaseDeDatos.GuardarKit(frmNuevoProducto.Producto);
                    // Recargamos la lista de productos kits
                    _productos = BaseDeDatos.LeerKits(); // Asegúrate de que esta función devuelve una lista de Producto

                    // Limpiamos y rellenamos el ListView
                    lvProductos.Items.Clear();

                    foreach (var producto in _productos)
                    {
                        var item = new ListViewItem(producto.Id.ToString());
                        item.SubItems.Add(producto.Codigo);
                        item.SubItems.Add(producto.Descripcion);
                        item.SubItems.Add(producto.Categoria);
                        item.SubItems.Add(producto.Marca);
                        item.SubItems.Add(producto.Precio.ToString("C"));

                        lvProductos.Items.Add(item);
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

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
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();

            // Definir columnas del carrito
            dataGridcarrito.Columns.Add("Id", "Id");
            dataGridcarrito.Columns.Add("Codigo", "Código");
            dataGridcarrito.Columns.Add("Descripcion", "Descripción");
            dataGridcarrito.Columns.Add("Categoria", "Categoría");
            dataGridcarrito.Columns.Add("Marca", "Marca");
            dataGridcarrito.Columns.Add("Precio", "Precio");

            // Asociar el evento Load correctamente
            this.Load += FormularioProductos_Load;

            // Asociar el evento CellClick
            dataGridproductos.CellClick += dataGridproductos_CellClick;
        }

        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            // Limpiar filas antes de cargar (por si el formulario se reabre)
            dataGridproductos.Rows.Clear();

            // Cargar productos solo una vez
            foreach (var p in BaseDeDatos.LeerProductos())
            {
                if (!p.EsKit)
                    dataGridproductos.Rows.Add(p.Id, p.Codigo, p.Descripcion, p.Categoria, p.Marca, p.Precio);
            }
        }

        private void dataGridproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var fila = dataGridproductos.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    string idProducto = fila.Cells[0].Value.ToString();

                    // Verificar si ya está en el carrito
                    bool yaExiste = false;
                    foreach (DataGridViewRow filaCarrito in dataGridcarrito.Rows)
                    {
                        if (filaCarrito.Cells[0].Value != null && filaCarrito.Cells[0].Value.ToString() == idProducto)
                        {
                            yaExiste = true;
                            break;
                        }
                    }

                    if (!yaExiste)
                    {
                        object codigo = fila.Cells[1].Value;
                        object descripcion = fila.Cells[2].Value;
                        object categoria = fila.Cells[3].Value;
                        object marca = fila.Cells[4].Value;
                        object precio = fila.Cells[5].Value;

                        dataGridcarrito.Rows.Add(idProducto, codigo, descripcion, categoria, marca, precio);
                    }
                    else
                    {
                        MessageBox.Show("Producto añadido al carrito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

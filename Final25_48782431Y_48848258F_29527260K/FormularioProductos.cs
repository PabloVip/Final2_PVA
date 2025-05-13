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
            dataGridcarrito.Columns.Add("Cantidad", "Cantidad");

            // Asociar el evento Load
            this.Load += FormularioProductos_Load;
        }

        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            // Limpiar filas antes de cargar
            dataGridproductos.Rows.Clear();

            // Cargar productos una sola vez
            foreach (var p in BaseDeDatos.LeerProductos())
            {
                if (!p.EsKit)
                    dataGridproductos.Rows.Add(p.Id, p.Codigo, p.Descripcion, p.Categoria, p.Marca, p.Precio);
            }

            // Suscribir el evento CellClick solo una vez
            dataGridproductos.CellClick -= dataGridproductos_CellClick;
            dataGridproductos.CellClick += dataGridproductos_CellClick;
        }

        private void dataGridproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var fila = dataGridproductos.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    string idProducto = fila.Cells[0].Value.ToString();

                    // Mostrar el formulario personalizado de cantidad
                    using (var frmCantidad = new FormularioCantidad())
                    {
                        if (frmCantidad.ShowDialog() == DialogResult.OK)
                        {
                            int cantidad = frmCantidad.Cantidad;

                            object codigo = fila.Cells[1].Value;
                            object descripcion = fila.Cells[2].Value;
                            object categoria = fila.Cells[3].Value;
                            object marca = fila.Cells[4].Value;
                            object precio = fila.Cells[5].Value;

                            // Comprobar si el producto ya existe en el carrito
                            bool encontrado = false;
                            foreach (DataGridViewRow filaCarrito in dataGridcarrito.Rows)
                            {
                                if (filaCarrito.Cells[0].Value != null && filaCarrito.Cells[0].Value.ToString() == idProducto)
                                {
                                    // Sumar la cantidad
                                    int cantidadExistente = Convert.ToInt32(filaCarrito.Cells[6].Value);
                                    filaCarrito.Cells[6].Value = cantidadExistente + cantidad;
                                    encontrado = true;
                                    break;
                                }
                            }

                            if (!encontrado)
                            {
                                // Si no existe, agregar como nueva fila
                                dataGridcarrito.Rows.Add(idProducto, codigo, descripcion, categoria, marca, precio, cantidad);
                            }
                        }
                    }
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridcarrito.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridcarrito.SelectedRows)
                {
                    dataGridcarrito.Rows.Remove(fila);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila del carrito para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnvolverproductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GenerarContenidoFactura()
        {
            string factura = "Factura\n\n";
            double total = 0.0;

            foreach (DataGridViewRow fila in dataGridcarrito.Rows)
            {
                if (!fila.IsNewRow)
                {
                    // Aquí debes usar los nombres SIN tilde, como los declaraste al crear las columnas del carrito.
                    string codigo = fila.Cells["Codigo"].Value?.ToString();
                    string descripcion = fila.Cells["Descripcion"].Value?.ToString();
                    double precio = Convert.ToDouble(fila.Cells["Precio"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    double subtotal = precio * cantidad;

                    factura += $"{cantidad} x {descripcion} ({codigo}) - {precio:C} = {subtotal:C}\n";
                    total += subtotal;
                }
            }

            factura += $"\nTotal: {total:C}";
            return factura;
        }




        private void btncrearfactura_Click(object sender, EventArgs e)
        {
            string contenidoFactura = GenerarContenidoFactura();
            FormularioFactura ventanaFactura = new FormularioFactura(contenidoFactura);
            ventanaFactura.ShowDialog();
        }
    }
}

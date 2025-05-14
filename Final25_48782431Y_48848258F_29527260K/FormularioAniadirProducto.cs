using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioAniadirProducto : Form
    {
        public string codigoProducto { get; private set; }
        public string cantidad { get; private set; }
        public FormularioAniadirProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lvProductos.SelectedItems.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione un producto y una cantidad");
                return;
            }

            codigoProducto = lvProductos.SelectedItems[0].SubItems[1].ToString(); 
            cantidad = tbCantidad.Text;

            if (!BaseDeDatos.ProductoExiste(codigoProducto))
            {
                MessageBox.Show("Ese producto no existe");
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            if (string.IsNullOrWhiteSpace(cantidad) || !decimal.TryParse(cantidad, out decimal cantidadDeciamal))
            {
                MessageBox.Show("Por favor, introduzca una cantidad válida");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormularioAniadirProducto_Load(object sender, EventArgs e)
        {
            lvProductos.Items.Clear();

            // Leemos los productos actualizados del kit
            var productos= BaseDeDatos.LeerProductos();
            
            if (!productos.Any())
                return;

            foreach (var pk in productos)
            {
                var item = new ListViewItem(pk.Id.ToString());
                item.SubItems.Add(pk.Codigo);
                item.SubItems.Add(pk.Descripcion);
                item.SubItems.Add(pk.Categoria);
                item.SubItems.Add(pk.Marca);
                item.SubItems.Add(pk.Precio.ToString("C"));
                lvProductos.Items.Add(item);
            }
        }
    }
}

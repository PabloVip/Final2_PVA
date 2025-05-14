using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Final25_48782431Y_48848258F_29527260K.Clases;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioNuevoProducto : Form
    {
        private List<Categoria> _categorias;
        private List<Marca> _marcas;

        public Producto Producto { get; set; } = new Producto();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="esKit">Para cuando creamos un producto nuevo indicarle si es un kit o no</param>
        /// <param name="producto">Para poder pasar o no un producto/kit para poder editar sus campos</param>
        public FormularioNuevoProducto(bool esKit, Producto producto = null)
        {
            InitializeComponent();

            // Para que no se pueda modificar. Lo asigno en el constructor
            // dependiendo de si es un producto normal o un kit
            chkEsKit.Enabled = false; 
            chkEsKit.Checked = esKit;
            Producto.EsKit = esKit;

            // Cargamos los combos
            comboCategoria.Items.Clear();
            _categorias = BaseDeDatos.LeerCategorias();
            comboCategoria.Items.AddRange(_categorias.Select(x => x.Id).ToArray());

            comboMarca.Items.Clear();
            _marcas = BaseDeDatos.LeerMarcas();
            comboMarca.Items.AddRange(_marcas.Select(x => x.Id).ToArray());

            if (producto != null)
            {
                txtId.Text = producto.Id.ToString();
                txtCodigo.Text = producto.Codigo;
                txtDescripcion.Text = producto.Descripcion;
                comboCategoria.SelectedItem = producto.Categoria;
                comboMarca.SelectedItem = producto.Marca;
                txtPrecio.Text = producto.Precio.ToString();
            }
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboCategoria.SelectedItem.ToString()))
            {
                MessageBox.Show("Seleccione una categoria");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboMarca.SelectedItem.ToString()))
            {
                MessageBox.Show("Seleccione una marca");
                return;
            }

            try
            {
                // Si es un nuevo producto, el campo de Id esta vacio. Si estamos editando, tendria valor
                if (string.IsNullOrWhiteSpace(txtId.Text))
                    Producto.Id = 0;
                else
                    Producto.Id = Int32.Parse(txtId.Text);
                
                Producto.Codigo = txtCodigo.Text;
                Producto.Descripcion = txtDescripcion.Text;
                Producto.Categoria = comboCategoria.SelectedItem.ToString();
                Producto.Marca = comboMarca.SelectedItem.ToString();

                // Convert devuelve cero si no hay valor. Parse da error.
                // Cambio el punto decimal por coma para que se guarde bien
                Producto.Precio = Convert.ToDecimal(txtPrecio.Text.Replace('.',','));

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error asignando datos: " + ex.Message);
            }
        }
    }
}

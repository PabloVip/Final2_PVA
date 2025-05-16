using System;
using System.Windows.Forms;
using Final25_48782431Y_48848258F_29527260K.Clases;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioCategoria : Form
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }

        public FormularioCategoria(Categoria categoria = null)
        {
            InitializeComponent();

            if (categoria != null)
            {
                txtId.Text = categoria.Id;
                txtDescripcion.Text = categoria.Descripcion;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Id = txtId.Text;
            Descripcion = txtDescripcion.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}

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
    public partial class FormularioCantidad : Form
    {
        public int Cantidad { get; private set; }

        public FormularioCantidad()
        {
            InitializeComponent();
            this.AcceptButton = btnAceptar;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                Cantidad = cantidad;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido mayor que 0.");
            }
        }

        private void FormularioCantidad_Load(object sender, EventArgs e)
        {

        }
    }
}

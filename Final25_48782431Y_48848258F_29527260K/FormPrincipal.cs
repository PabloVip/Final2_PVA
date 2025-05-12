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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_vercatalogo_Click(object sender, EventArgs e)
        {
            FormularioKits nuevoFormulario = new FormularioKits();
            nuevoFormulario.Show();
        }

        private void btn_crearkit_Click(object sender, EventArgs e)
        {
            FormularioProductos nuevoFormulario = new FormularioProductos();
            nuevoFormulario.Show();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 nuevoFormulario = new Form1();
            nuevoFormulario.Show();
        }
    }
}

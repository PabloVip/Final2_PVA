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
    public partial class FormAdmin : Form
    {
        private bool cerrandoSesion = false;

        public FormAdmin(String usuario)
        {
            InitializeComponent();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            BaseDeDatos.Logout(); // Pongo a null la informacion del usuario activo.
            cerrandoSesion = true;
            this.Close();
            Form1 nuevoFormulario = new Form1();
            nuevoFormulario.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}

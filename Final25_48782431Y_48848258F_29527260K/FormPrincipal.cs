using System;
using System.Windows.Forms;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormPrincipal : Form
    {
        private bool cerrandoSesion = false;

        public FormPrincipal()
        {
            InitializeComponent();
            this.FormClosed += FormPrincipal_FormClosed;
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
            cerrandoSesion = true;
            this.Close();
            Form1 nuevoFormulario = new Form1();
            nuevoFormulario.Show();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!cerrandoSesion)
            {
                Application.Exit();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar datos o dar bienvenida
        }
    }
}

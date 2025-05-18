using Final25_48782431Y_48848258F_29527260K.Clases;
using System;
using System.Windows.Forms;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormPrincipal : Form
    {
        private bool cerrandoSesion = false;

        public FormPrincipal(String usuario)
        {
            InitializeComponent();
            this.FormClosed += FormPrincipal_FormClosed;

            

            lblEmpresa.Text = BaseDeDatos.UsuarioActivo.Empresa;
            lblUsuario.Text = BaseDeDatos.UsuarioActivo.Nombre;

            // label_usuario.Text = "Bienvenid@ " + usuario;
        }

        

        private void btn_crearkit_Click(object sender, EventArgs e)
        {
            FormularioProductos nuevoFormulario = new FormularioProductos();
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

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

       

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var form = new FormularioProductos2();
            form.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            var form = new FormularioMarcas();
            form.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var form = new FormularioCategorias();
            form.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            var form = new FormularioFacturas();
            form.Show();
        }

        private void btn_vercatalogo_Click_1(object sender, EventArgs e)
        {
            FormularioKits nuevoFormulario = new FormularioKits(false);
            nuevoFormulario.Show();
        }

        private void btn_crearkit_Click_1(object sender, EventArgs e)
        {
            FormularioKits nuevoFormulario = new FormularioKits(false);
            nuevoFormulario.Show();
        }

        private void btncerrarsesion_Click_1(object sender, EventArgs e)
        {
            BaseDeDatos.Logout(); // Pongo a null la informacion del usuario activo.
            cerrandoSesion = true;
            this.Close();
            Form1 nuevoFormulario = new Form1();
            nuevoFormulario.Show();
        }
    }
}

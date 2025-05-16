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
            this.FormClosing += FormAdmin_FormClosing;
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            BaseDeDatos.Logout(); // Pongo a null la informacion del usuario activo.
            cerrandoSesion = true;
            this.Close();
            Form1 nuevoFormulario = new Form1();
            nuevoFormulario.Show();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solo mostramos el mensaje de confirmación si no estamos cerrando la aplicación a través de un proceso explícito
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de que quieres salir?",
                                                     "Confirmar salida",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_vercatalogo_Click(object sender, EventArgs e)
        {
            FormularioKits nuevoFormulario = new FormularioKits(true);
            nuevoFormulario.Show();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            AdministrarUsuarios formularioUsuarios = new AdministrarUsuarios();
            formularioUsuarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FormularioFacturas();
            form.Show();
        }
    }
}

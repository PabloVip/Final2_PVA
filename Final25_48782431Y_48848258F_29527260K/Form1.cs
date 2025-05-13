using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Final25_48782431Y_48848258F_29527260K.Clases;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class Form1 : Form
    {
        //VARIABLES GLOBALES
        
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = tb_usuario.Text;
            string contrasena = tb_contraseña.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(usuario)
                    || string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Los campos usuario y contraseña deben tener algún valor");
                    return;
                }

                if (BaseDeDatos.CompruebaUsuario(usuario, contrasena))
                {
                    Usuario mi_usuario = BaseDeDatos.LeerUsuario(usuario, contrasena);
                    if (mi_usuario.RollId != "ADMINISTRADOR")
                    {                     FormPrincipal principal = new FormPrincipal(usuario);
                                          principal.Show();
                                          this.Hide();
                    
                    } else {
                        FormAdmin admin = new FormAdmin(usuario);
                        admin.Show();
                        this.Hide();
                    }

                }
                    else
                    MessageBox.Show("Usuario o contraseña incorrectos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

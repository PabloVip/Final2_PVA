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

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class Form1 : Form
    {
        //VARIABLES GLOBALES
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string conexion = "server=(local)\\SQLEXPRESS;database=PAYAVISOLAR; Integrated Security=SSPI";
            string usuario = tb_usuario.Text;
            string contrasena = tb_contraseña.Text;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contrasena = @contrasena";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        FormPrincipal principal = new FormPrincipal();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

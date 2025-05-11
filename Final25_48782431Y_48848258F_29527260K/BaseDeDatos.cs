using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Final25_48782431Y_48848258F_29527260K.Clases;
using System.Security.Policy;
using System.Windows.Forms;

namespace Final25_48782431Y_48848258F_29527260K
{
    public class BaseDeDatos
    {
        private const string CadenaConexion = "server=(local)\\SQLEXPRESS;database=PAYAVISOLAR; Integrated Security=SSPI";


        public static List<Producto> LeerProductos()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                try
                {
                    var conexión = new SqlConnection(CadenaConexion);
                    conexión.Open();
                    var command = new SqlCommand();
                    command.Connection = conexión;
                    command.CommandText = "SELECT * FROM PRODUCTOS";
                    var dt = command.ExecuteReader();

                    var productos = new List<Producto>();

                    while (dt.Read())
                    {
                        var pt = new Producto();
                        pt.Id = dt.GetInt32(0);
                        pt.Codigo = dt.GetString(1);
                        pt.Descripcion = dt.GetString(2);
                        pt.Categoria = dt.GetString(3);
                        pt.Marca = dt.GetString(4);
                        pt.Precio = dt.GetDecimal(5);
                        pt.EsKit = dt.GetBoolean(6);
                        productos.Add(pt);
                    }

                    return productos;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public static List<Usuario> LeerUsuarios()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                try
                {
                    string query = "SELECT * FROM Usuarios";
                    conexion.Open();
                    var command = new SqlCommand();
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM Usuarios";
                    var dt = command.ExecuteReader();

                    var usuarios = new List<Usuario>();

                    while (dt.Read())
                    {
                        var user = new Usuario();
                        user.Id = dt.GetInt32(0);
                        user.Empresa = dt.GetString(1);
                        user.Nombre = dt.GetString(2);
                        user.Direccion = dt.GetString(3);
                        user.Poblacion = dt.GetString(4);
                        user.CodigoPostal = dt.GetString(5);
                        user.Provincia = dt.GetString(6);
                        user.Pais = dt.GetString(7);
                        user.Email = dt.GetString(8);
                        user.FechaCreacion = dt.GetDateTime(9);
                        user.Nif = dt.GetString(10);
                        user.RollId = dt.GetString(11);
                        user.Password = dt.GetString(12);
                        usuarios.Add(user);
                    }

                    return usuarios;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public static bool CompruebaUsuario(string usuario, string password)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @usuario AND Password = @contrasena";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", password);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                        return true;

                }
                finally
                {
                    conn.Close();
                }

                return false;

            }
        }
    }
}

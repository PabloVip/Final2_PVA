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


        public static List<Producto> LeerKits()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                try
                {
                    var conexión = new SqlConnection(CadenaConexion);
                    conexión.Open();
                    var command = new SqlCommand();
                    command.Connection = conexión;
                    command.CommandText = "SELECT * FROM PRODUCTOS WHERE EsKit=1";
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

        public static void GrabarFactura(FacturaCabecera factura)
        {
            var fechaCreacion = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    conn.Open();
                    var query = @"INSERT INTO FacturaCabeceras(ClienteId, FechaCreacion) VALUES
                            (@ClienteId, @FechaCreacion)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ClienteId", factura.ClienteId);
                    cmd.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);

                    cmd.ExecuteNonQuery();

                    //CONSULTO EL ID DE LA CABECERA DE FACTURA QUE ACABO DE GRABAR PARA PONERLO EN LAS LINEAS
                    query = "SELECT Id FROM FacturaCabeceras WHERE FechaCreacion=@FechaCreacion";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);
                    var id = (int)cmd.ExecuteScalar();

                    var query2 = @"INSERT INTO FacturaLineas(FacturaId, Linea, ProductoId, CodigoProducto,
                        Descripcion, Cantidad, Precio, Total) 
                        VALUES (@FacturaId, @Linea, @ProductoId, @CodigoProducto,
                        @Descripcion, @Cantidad, @Precio, @Total)";

                    int contadorLinea = 1;

                    foreach (var linea in factura.Lineas)
                    {
                        var cmd2 = new SqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@FacturaId", id);
                        cmd2.Parameters.AddWithValue("@Linea", contadorLinea);
                        cmd2.Parameters.AddWithValue("@ProductoId", linea.ProductoId);
                        cmd2.Parameters.AddWithValue("@CodigoProducto", linea.CodigoProducto);
                        cmd2.Parameters.AddWithValue("@Descripcion", linea.Descripcion);
                        cmd2.Parameters.AddWithValue("@Cantidad", linea.Cantidad);
                        cmd2.Parameters.AddWithValue("@Precio", linea.Precio);
                        cmd2.Parameters.AddWithValue("@Total", linea.Total);

                        cmd.ExecuteNonQuery();

                        contadorLinea++;
                    }

                }
                finally
                {
                    conn.Close();
                }

            }
        }
        public static List<ProductoKit> LeerProductosKits()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                try
                {
                    var conexión = new SqlConnection(CadenaConexion);
                    conexión.Open();
                    var command = new SqlCommand();
                    command.Connection = conexión;
                    command.CommandText = @"SELECT p.Id, p.Codigo, p.Descripcion, p.Categoria
                                           p.Marca, p.Precio, k.Cantidad
                                           FROM ProductosKit k inner join Productos p on p.Id = k.ProductoId";
                    var dt = command.ExecuteReader();

                    var productosKit = new List<ProductoKit>();

                    while (dt.Read())
                    {
                        var pt = new ProductoKit();
                        pt.Id = dt.GetInt32(0);
                        pt.Codigo = dt.GetString(1);
                        pt.Descripcion = dt.GetString(2);
                        pt.Categoria = dt.GetString(3);
                        pt.Marca = dt.GetString(4);
                        pt.Precio = dt.GetDecimal(5);
                        pt.Cantidad = dt.GetDecimal(6);
                        productosKit.Add(pt);
                    }

                    return productosKit;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

    }
    
}

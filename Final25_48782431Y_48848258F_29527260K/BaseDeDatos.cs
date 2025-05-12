using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Final25_48782431Y_48848258F_29527260K.Clases;
using Microsoft.VisualBasic.ApplicationServices;

namespace Final25_48782431Y_48848258F_29527260K
{
    public class BaseDeDatos
    {
        private const string CadenaConexion = "server=(local)\\SQLEXPRESS;database=PAYAVISOLAR; Integrated Security=SSPI";

        /// <summary>
        /// Propiedad para guardar el usuario que ha hecho login en la aplicacion
        /// </summary>
        public static Usuario UsuarioActivo { get; set; }



        /// <summary>
        /// Metodo para leer todos los productos que no son kit
        /// </summary>
        /// <returns></returns>
        public static List<Producto> LeerProductos()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM PRODUCTOS WHERE EsKit=0";
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


        /// <summary>
        /// Metodo para leer todos los productos que son kit
        /// </summary>
        /// <returns></returns>
        public static List<Producto> LeerKits()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
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

        /// <summary>
        /// Metodo para leer todos los usuarios
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> LeerUsuarios()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
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

        /// <summary>
        /// Metodo para leer los roles
        /// </summary>
        /// <returns></returns>
        public static List<Rol> LeerRoles()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM ROLES";
                    var dt = command.ExecuteReader();

                    var roles = new List<Rol>();

                    while (dt.Read())
                    {
                        var pt = new Rol();
                        pt.Id = dt.GetString(0);
                        pt.Descripcion = dt.GetString(1);
                        roles.Add(pt);
                    }

                    return roles;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Metodo para el login de la aplicacion y ver si un usuario existe y su contraseña es correcta
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CompruebaUsuario(string usuario, string password)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @usuario AND Password = @contrasena";
                    command.CommandText = query;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", password);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        UsuarioActivo = LeerUsuario(usuario, password);
                        return true;
                    }

                }
                finally
                {
                    conn.Close();
                }

                return false;

            }
        }


        public static Usuario LeerUsuario(string usuario, string password)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM Usuarios WHERE Email = @usuario AND Password = @contrasena";
                    var dt = command.ExecuteReader();

                    dt.Read();
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
                    user.RollId = dt.GetString(111);

                    return user;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Metodo para poner a null el usuario activo en la aplicacion para cuando se cierra la sesion
        /// </summary>
        public static void Logout()
        {
            UsuarioActivo = null;
        }


        /// <summary>
        /// Metodo para guardar un nuevo usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void GuardarUsuario(Usuario usuario)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = @"INSERT INTO USUARIO (Empresa, Nombre, Direccion, Poblacion, CodigoPostal,
                        Provincia, Pais, Email, FechaCreacion, Nif, RolId, Password) 
                        VALUES (@Empresa, @Nombre, @Direccion, @Poblacion, @CodigoPostal,
                        @Provincia, @Pais, @Email, @FechaCreacion, @Nif, @RolId, @Password)";
                    command.Parameters.AddWithValue("@Empresa", usuario.Empresa);
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                    command.Parameters.AddWithValue("@Poblacion", usuario.Poblacion);
                    command.Parameters.AddWithValue("@CodigoPostal", usuario.CodigoPostal);
                    command.Parameters.AddWithValue("@Provincia", usuario.Provincia);
                    command.Parameters.AddWithValue("@Pais", usuario.Pais);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                    command.Parameters.AddWithValue("@Nif", usuario.Nif);
                    command.Parameters.AddWithValue("@RolId", usuario.RollId);
                    command.Parameters.AddWithValue("@Password", usuario.Password);
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        /// <summary>
        /// Metodo para grabar una factura
        /// </summary>
        /// <param name="factura">Cabecera de factura con sus lineas incluidas</param>
        public static void GrabarFactura(FacturaCabecera factura)
        {
            var fechaCreacion = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conn.Open();
                    var query = @"INSERT INTO FacturaCabeceras(ClienteId, FechaCreacion) VALUES
                            (@ClienteId, @FechaCreacion)";

                    command.CommandText = query;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@ClienteId", factura.ClienteId);
                    command.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);

                    command.ExecuteNonQuery();

                    //CONSULTO EL ID DE LA CABECERA DE FACTURA QUE ACABO DE GRABAR PARA PONERLO EN LAS LINEAS
                    query = "SELECT Id FROM FacturaCabeceras WHERE FechaCreacion=@FechaCreacion";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);
                    var id = (int)cmd.ExecuteScalar();
                    cmd.Dispose();

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

                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                        contadorLinea++;
                    }

                }
                finally
                {
                    conn.Close();
                }

            }
        }

        /// <summary>
        /// Metodo para consultar los productos que pertenecen a un kit y sus cantidades
        /// </summary>
        /// <param name="kitId">el Id del kit, que es el Id del producto que representa al kit</param>
        /// <returns></returns>
        public static List<ProductoKit> LeerProductosDeUnKit(int kitId)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = @"SELECT p.Id, p.Codigo, p.Descripcion, p.Categoria,
                                           p.Marca, p.Precio, k.Cantidad
                                           FROM ProductoKits k 
                                           INNER JOIN Productos p on p.Id = k.ProductoId
                                           WHERE k.Id = @kitId";
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
      

        /// <summary>
        /// Metodo para guardar un nuevo producto que es kit
        /// </summary>
        /// <param name="kit">Producto que es kit</param>
        /// <param name="productosDelKit">Lista de productos que incluye el kit</param>
        public void GuardarNuevoKit(Producto kit, List<ProductoKit> productosDelKit)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conn.Open();
                    var query = @"INSERT INTO Producto(Codigo, Descripcion, Categoria, Marca, Precio, EsKit) VALUES
                            (@Codigo, @Descripcion, @Categoria, @Marca, @Precio, @EsKit)";

                    command.CommandText = query;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@Codigo", kit.Codigo);
                    command.Parameters.AddWithValue("@Descripcion", kit.Descripcion);
                    command.Parameters.AddWithValue("@Categoria", kit.Categoria);
                    command.Parameters.AddWithValue("@Marca", kit.Marca);
                    command.Parameters.AddWithValue("@Precio", kit.Precio);
                    command.Parameters.AddWithValue("@EsKit", 1);
                    
                    command.ExecuteNonQuery();

                    // Leemos el ID del ultimo producto creado que es un kit
                    query = "SELECT TOP 1 Id FROM Productos WHERE EsKit=1 ORDER BY Id DESC";
                    var cmd = new SqlCommand(query, conn);
                    var idKit = (int)cmd.ExecuteScalar();
                    cmd.Dispose();

                    // Insertamos las lineas de productos del kit
                    query = @"INSERT INTO ProductoKits(Id, ProductoId, Cantidad) VALUES
                            (@Id, @ProductoId, @Cantidad)";
                    foreach (var producto in productosDelKit)
                    {
                        var cmd2 = new SqlCommand(query, conn);
                        cmd2.Parameters.AddWithValue("@Id", idKit);
                        cmd2.Parameters.AddWithValue("@ProductoId", producto.Id);
                        cmd2.Parameters.AddWithValue("@Cantidad", producto.Cantidad);

                        cmd.ExecuteNonQuery();
                        cmd2.Dispose();
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        /// <summary>
        /// Metodo para leer las marcas
        /// </summary>
        /// <returns></returns>
        public static List<Marca> LeerMarcas()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM MARCAS";
                    var dt = command.ExecuteReader();

                    var marcas = new List<Marca>();

                    while (dt.Read())
                    {
                        var pt = new Marca();
                        pt.Id = dt.GetString(0);
                        pt.Descripcion = dt.GetString(1);
                        marcas.Add(pt);
                    }

                    return marcas;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Metodo para guardar una nueva marca
        /// </summary>
        /// <param name="marca"></param>
        public static void GuardarMarca(Marca marca)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = "INSERT INTO MARCAS(Id, Descripcion) VALUES (@Id, @Descripcion)";
                    command.Parameters.AddWithValue("@Id", marca.Id);
                    command.Parameters.AddWithValue("@Descripcion", marca.Descripcion);
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        ///  Metodo para leer las categorias
        /// </summary>
        /// <returns></returns>
        public static List<Categoria> LeerCategorias()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = "SELECT * FROM CATEGORIAS";
                    var dt = command.ExecuteReader();

                    var categorias = new List<Categoria>();

                    while (dt.Read())
                    {
                        var pt = new Categoria();
                        pt.Id = dt.GetString(0);
                        pt.Descripcion = dt.GetString(1);
                        categorias.Add(pt);
                    }

                    return categorias;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Metodo para guardar una nueva categoria
        /// </summary>
        /// <param name="categoria"></param>
        public static void GuardarCategoria(Categoria categoria)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    conexion.Open();
                    command.Connection = conexion;
                    command.CommandText = "INSERT INTO CATEGORIAS(Id, Descripcion) VALUES (@Id, @Descripcion)";
                    command.Parameters.AddWithValue("@Id", categoria.Id);
                    command.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conexion.Close();
                }
            }
        }




    }
}

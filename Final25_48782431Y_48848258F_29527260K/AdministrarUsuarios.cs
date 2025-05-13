using Final25_48782431Y_48848258F_29527260K.Clases;
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
    public partial class AdministrarUsuarios : Form
    {
        List<Usuario> usuarios = BaseDeDatos.LeerUsuarios();

        public AdministrarUsuarios()
        {
            InitializeComponent();
            this.Load += AdministrarUsuarios_Load; // Suscribimos el evento Load
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnListView();
        }

        private void CargarUsuariosEnListView()
        {
            // Configuración básica
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Agregamos columnas si aún no existen

            listView1.Items.Clear();

            foreach (var user in usuarios)
            {
                ListViewItem item = new ListViewItem(user.Id.ToString());
                item.SubItems.Add(user.Empresa);
                item.SubItems.Add(user.Nombre);
                item.SubItems.Add(user.Direccion);
                item.SubItems.Add(user.Poblacion);
                item.SubItems.Add(user.CodigoPostal);
                item.SubItems.Add(user.Provincia);
                item.SubItems.Add(user.Pais);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.FechaCreacion.ToString("dd/MM/yyyy"));
                item.SubItems.Add(user.Nif);
                item.SubItems.Add(user.RollId);
                item.SubItems.Add(user.Password);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0]; // La fila seleccionada

                // Asumiendo que tienes TextBox con estos nombres:
                tb_empresa.Text = item.SubItems[1].Text;
                tb_nombre.Text = item.SubItems[2].Text;
                tb_direccion.Text = item.SubItems[3].Text;
                tb_poblacion.Text = item.SubItems[4].Text;
                tb_CP.Text = item.SubItems[5].Text;
                tb_provincia.Text = item.SubItems[6].Text;
                tb_pais.Text = item.SubItems[7].Text;
                tb_email.Text = item.SubItems[8].Text;
                tb_fechacreacion.Text = item.SubItems[9].Text;
                tb_nif.Text = item.SubItems[10].Text;
                tb_rolid.Text = item.SubItems[11].Text;
                tb_password.Text = item.SubItems[12].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = listView1.SelectedItems[0]; // La fila seleccionada
            BaseDeDatos.EliminarUsuario(int.Parse(item.SubItems[0].Text));
            usuarios = BaseDeDatos.LeerUsuarios();  // Recargar desde la base de datos
            CargarUsuariosEnListView();
        }

        private void bt_añadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos básicos
                if (string.IsNullOrWhiteSpace(tb_email.Text) || string.IsNullOrWhiteSpace(tb_password.Text))
                {
                    MessageBox.Show("Email y contraseña son obligatorios.");
                    return;
                }

                Usuario nuevoUsuario = new Usuario
                {
                    Empresa = tb_empresa.Text,
                    Nombre = tb_nombre.Text,
                    Direccion = tb_direccion.Text,
                    Poblacion = tb_poblacion.Text,
                    CodigoPostal = tb_CP.Text,
                    Provincia = tb_provincia.Text,
                    Pais = tb_pais.Text,
                    Email = tb_email.Text,
                    FechaCreacion = DateTime.Parse(tb_fechacreacion.Text),
                    Nif = tb_nif.Text,
                    RollId = tb_rolid.Text,
                    Password = tb_password.Text
                };

                BaseDeDatos.GuardarUsuario(nuevoUsuario); // Debe existir este método
                MessageBox.Show("Usuario añadido correctamente.");

                usuarios = BaseDeDatos.LeerUsuarios();  // Recargar lista
                CargarUsuariosEnListView();             // Refrescar tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir usuario: " + ex.Message);
            }
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecciona un usuario de la lista para modificar.");
                    return;
                }

                var item = listView1.SelectedItems[0];
                int id = int.Parse(item.SubItems[0].Text); 

                // Validar campos básicos
                if (string.IsNullOrWhiteSpace(tb_email.Text) || string.IsNullOrWhiteSpace(tb_password.Text))
                {
                    MessageBox.Show("Email y contraseña son obligatorios.");
                    return;
                }

                DateTime fecha;
                if (!DateTime.TryParse(tb_fechacreacion.Text, out fecha))
                {
                    MessageBox.Show("La fecha no es válida.");
                    return;
                }

                Usuario usuarioModificado = new Usuario
                {
                    Id = id,
                    Empresa = tb_empresa.Text,
                    Nombre = tb_nombre.Text,
                    Direccion = tb_direccion.Text,
                    Poblacion = tb_poblacion.Text,
                    CodigoPostal = tb_CP.Text,
                    Provincia = tb_provincia.Text,
                    Pais = tb_pais.Text,
                    Email = tb_email.Text,
                    FechaCreacion = fecha,
                    Nif = tb_nif.Text,
                    RollId = tb_rolid.Text,
                    Password = tb_password.Text
                };

                BaseDeDatos.ModificarUsuario(usuarioModificado);

                MessageBox.Show("Usuario modificado correctamente.");

                usuarios = BaseDeDatos.LeerUsuarios();  // Recargar lista
                CargarUsuariosEnListView();             // Refrescar tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message);
            }
        }


    }
}



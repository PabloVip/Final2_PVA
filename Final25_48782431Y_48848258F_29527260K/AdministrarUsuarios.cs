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
                tb_id.Text = item.SubItems[0].Text;
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
            BaseDeDatos.EliminarUsuario(int.Parse(tb_id.Text));
            usuarios = BaseDeDatos.LeerUsuarios();  // Recargar desde la base de datos
            CargarUsuariosEnListView();
        }
    }
}



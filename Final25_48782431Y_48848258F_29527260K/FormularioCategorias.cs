using Final25_48782431Y_48848258F_29527260K.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioCategorias : Form
    {
        private List<Categoria> _categorias;

        public FormularioCategorias()
        {
            InitializeComponent();
        }

        private void CargaCategorias()
        {
            lvCategorias.Items.Clear();
            _categorias = BaseDeDatos.LeerCategorias();

            foreach (var categoria in _categorias)
            {
                var item = new ListViewItem(categoria.Id);
                item.SubItems.Add(categoria.Descripcion);
                lvCategorias.Items.Add(item);
            }
        }

        private void FormularioCategorias_Load(object sender, EventArgs e)
        {
            CargaCategorias();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormularioCategoria();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    BaseDeDatos.GuardarCategoria(form.Id, form.Descripcion);
                    CargaCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creando la categoría: " + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvCategorias.SelectedItems.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione una categoría");
                return;
            }

            try
            {
                if (MessageBox.Show("¿Quiere eliminar la categoría?", "", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    var idCategoria = lvCategorias.SelectedItems[0].SubItems[0].Text;

                    if (BaseDeDatos.CompruebaCategoriaUtilizada(idCategoria))
                    {
                        MessageBox.Show("Atención: no se puede eliminar la categoría porque está en uso en algún producto",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BaseDeDatos.EliminarCategoria(idCategoria);
                    CargaCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando la categoría: " + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvCategorias.SelectedItems.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione una categoría");
                return;
            }

            try
            {
                var categoria = _categorias.First(x => x.Id == lvCategorias.SelectedItems[0].SubItems[0].Text);
                var form = new FormularioCategoria(categoria);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    BaseDeDatos.ModificaCategoria(form.Id, form.Descripcion);
                    CargaCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editando la categoría: " + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

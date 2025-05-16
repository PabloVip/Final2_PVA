using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Final25_48782431Y_48848258F_29527260K.Clases;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioMarcas : Form
    {
        private List<Marca> _marcas;

        public FormularioMarcas()
        {
            InitializeComponent();
        }

        private void CargaMarcas()
        {
            lvMarcas.Items.Clear();
            _marcas = BaseDeDatos.LeerMarcas();

            foreach (var marca in _marcas)
            {
                var item = new ListViewItem(marca.Id);
                item.SubItems.Add(marca.Descripcion);
                lvMarcas.Items.Add(item);
            }
        }

        private void FormularioMarcas_Load(object sender, EventArgs e)
        {
            CargaMarcas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormularioMarca();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    BaseDeDatos.GuardarMarca(form.Id, form.Descripcion);
                    CargaMarcas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editando la marca: " + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvMarcas.SelectedItems.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione una marca");
                return;
            }

            try
            {
                if (MessageBox.Show("¿Quiere eliminar la marca?", "", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    var idMarca = lvMarcas.SelectedItems[0].SubItems[0].Text;

                    if (BaseDeDatos.CompruebaMarcaUtilizada(idMarca))
                    {
                        MessageBox.Show("Atención: no se puede eliminar la marca porque está en uso en algún producto",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BaseDeDatos.EliminarMarca(idMarca);
                    CargaMarcas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando la marca: " + ex, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvMarcas.SelectedItems.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione una marca");
                return;
            }

            try
            {
                var marca = _marcas.First(x => x.Id == lvMarcas.SelectedItems[0].SubItems[0].Text);
                var form = new FormularioMarca(marca);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    BaseDeDatos.ModificaMarca(form.Id, form.Descripcion);
                    CargaMarcas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editando la marca: " + ex, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
    }
}

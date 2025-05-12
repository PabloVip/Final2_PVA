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
    public partial class FormularioKits : Form
    {
        public FormularioKits()
        {
            InitializeComponent();

            //CARGO LOS KITS AL COMBOBOX
            // el AddRange necesita un array en vez de una lista
            cbCatalogo.Items.AddRange(BaseDeDatos.LeerKits().Select(x => x.Codigo).ToArray());

            cbCatalogo.SelectedIndexChanged += cbCatalogo_SelectedIndexChanged;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioKits_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código .productosTableAdapter.Fill(this.pAYAVISOLARDataSet.Productos);
            

        }

        private void cbCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCatalogo.SelectedValue is string codigoKit)
            {
                var productosDelKit = BaseDeDatos.LeerProductosKitsPorCodigo(codigoKit);

                listView1.Items.Clear();

                foreach (var pk in productosDelKit)
                {
                    var item = new ListViewItem(pk.Id.ToString());
                    item.SubItems.Add(pk.Codigo);
                    item.SubItems.Add(pk.Descripcion);
                    item.SubItems.Add(pk.Categoria);
                    item.SubItems.Add(pk.Marca);
                    item.SubItems.Add(pk.Precio.ToString("C"));
                    item.SubItems.Add(pk.Cantidad.ToString("N2"));
                    listView1.Items.Add(item);
                }
            }
        }

    }
}

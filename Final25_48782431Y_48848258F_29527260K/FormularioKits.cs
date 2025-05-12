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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormularioFactura : Form
    {
        public FormularioFactura(string contenidoFactura)
        {
            InitializeComponent();
            richTextBoxFactura.Text = contenidoFactura;
        }

        private void FormularioFactura_Load(object sender, EventArgs e)
        {

        }
    }
}

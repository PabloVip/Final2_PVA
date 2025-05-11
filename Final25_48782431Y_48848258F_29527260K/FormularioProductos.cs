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
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();
        }

        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pAYAVISOLARDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.pAYAVISOLARDataSet.Productos);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class Form1 : Form
    {
        //VARIABLES GLOBALES
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FormPrincipal nuevoFormulario = new FormPrincipal();
            nuevoFormulario.Show();
            
        }
    }
}

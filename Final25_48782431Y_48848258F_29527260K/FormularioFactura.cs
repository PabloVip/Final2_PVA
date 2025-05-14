using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnPasarAExcel_Click(object sender, EventArgs e)
        {
            string nombreArchivo = $"Factura_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
            string rutaCompleta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo);

            using (StreamWriter writer = new StreamWriter(rutaCompleta, false, Encoding.UTF8))
            {
                writer.WriteLine("===============================================");
                writer.WriteLine("                 FACTURA                       ");
                writer.WriteLine("===============================================\n");

                writer.WriteLine(richTextBoxFactura.Text);  // Inserta el contenido actual de la factura

                writer.WriteLine("\n===============================================");
                writer.WriteLine("     ¡Gracias por confiar en nosotros!         ");
                writer.WriteLine("===============================================");
            }

            MessageBox.Show("Factura exportada como CSV correctamente en el escritorio.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir el archivo automáticamente
            System.Diagnostics.Process.Start("explorer.exe", rutaCompleta);
        }


        private void btnvolverfactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Final25_48782431Y_48848258F_29527260K.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioFacturas : Form
    {
        private List<Factura> _facturas;

        public FormularioFacturas()
        {
            InitializeComponent();
        }

        private void CargaFacturas()
        {
            lvFacturas.Items.Clear();
            _facturas = BaseDeDatos.LeerFacturas();

            foreach (var factura in _facturas)
            {
                var item = new ListViewItem(factura.Id.ToString());
                item.SubItems.Add(factura.ClienteId.ToString());
                item.SubItems.Add(factura.Empresa);
                item.SubItems.Add(factura.NombreCliente);
                item.SubItems.Add(factura.FechaCreacion.ToString("G"));
                item.SubItems.Add(factura.Total.ToString("C"));

                lvFacturas.Items.Add(item);
            }
        }

        private void FormularioFacturas_Load(object sender, EventArgs e)
        {
            CargaFacturas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

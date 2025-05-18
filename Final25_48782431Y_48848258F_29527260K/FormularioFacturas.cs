using Final25_48782431Y_48848258F_29527260K.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormularioFacturas : Form
    {
        private List<Factura> _facturas;

        public FormularioFacturas()
        {
            InitializeComponent();

            lvLineas.Items.Clear();
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

        private void lvFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFacturas.SelectedItems.Count != 1)
                return;

            lvLineas.Items.Clear();
            var idFactura = int.Parse(lvFacturas.SelectedItems[0].SubItems[0].Text);

            try
            {
                var factura = BaseDeDatos.LeerFactura(idFactura);
                if (factura.Lineas.Any())
                    foreach (var linea in factura.Lineas)
                    {
                        var item = new ListViewItem(linea.Linea.ToString());
                        item.SubItems.Add(linea.ProductoId.ToString());
                        item.SubItems.Add(linea.CodigoProducto);
                        item.SubItems.Add(linea.CodigoProducto);
                        item.SubItems.Add(linea.Descripcion);
                        item.SubItems.Add(linea.Cantidad.ToString());
                        item.SubItems.Add(linea.Precio.ToString("C"));
                        item.SubItems.Add(linea.Total.ToString("C"));

                        lvLineas.Items.Add(item);
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            

        }
    }
}

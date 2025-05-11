using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Final25_48782431Y_48848258F_29527260K.Clases
{
    public class FacturaCabecera
    {
        public int FacturaID { get; set; }
        public int Linea { get; set; }
        public int ProductoId { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
    }
}

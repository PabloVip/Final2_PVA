using System;

namespace Final25_48782431Y_48848258F_29527260K.Clases
{
    public class Factura
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Empresa { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal Total { get; set; }
    }
}
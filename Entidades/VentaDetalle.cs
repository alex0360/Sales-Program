using System;

namespace Entidades
{
    public class VentaDetalle
    {
        public string Factura { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public int IdProduccto { get; set; }
        public string DescripcionProducto { get; set; }
    }
}

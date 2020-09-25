using System;

namespace Entidades {
    public class Venta {
        //FECHA datetime no	8
        //ID_CLIENTE int no	4
        //ID_VENDEDOR int no	4
        //ID_PROD int no	4
        //CANTIDAD int no	4

        public string Factura { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public int IdProduccto { get; set; }
        public int Cantidad { get; set; }
    }
}

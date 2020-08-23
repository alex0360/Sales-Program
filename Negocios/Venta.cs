using System;

namespace Negocios
{
    public class Venta
    {
        Datos.Venta obj;
        public void InsertarVentas(Entidades.Venta entidad) {
            obj = new Datos.Venta();
            obj.InsertarVentas(entidad);
            obj.RebajarConceptos(entidad);
        }
        public System.Data.DataSet ObtenerVentas() {
            obj = new Datos.Venta();
            return obj.ObtenerVentas();
        }
        //public void RebajarConceptos(Entidades.Venta entidad) {
        //    obj = new Datos.Venta();
        //    obj.RebajarConceptos(entidad);
        //}
        public System.Data.DataSet ObtenerVentasClientes() {
            obj = new Datos.Venta();
            return obj.ObtenerVentasClientes();
        }

        public System.Data.DataTable MostrarBuscar(string textBuscar)
        {
            obj = new Datos.Venta();
            return obj.MostrarBuscar(textBuscar);
        }
    }
}

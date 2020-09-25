using System;
using System.Collections.Generic;

namespace Negocios {
    public class VendedorReport {
        public List<Entidades.Vendedor> ListObj { get; set; }

        public object CreateReport() {
            var list = new Datos.Vendedor();
            var result = list.Mostrar();
            _ = result.Tables[0].Columns.Count;

            ListObj = new List<Entidades.Vendedor>();
            foreach(System.Data.DataRow rows in result.Tables[0].Rows) {
                var ObjModel = new Entidades.Vendedor() {
                    IdVendedor = Convert.ToInt32(rows[0]),
                    NombreVendedor = Convert.ToString(rows[1]),
                    Oficina = Convert.ToString(rows[3]),
                    Comision = Convert.ToSingle(rows[4])
                };
                ListObj.Add(ObjModel);
            }
            return ListObj;
        }
    }
}

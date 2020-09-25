using System;
using System.Collections.Generic;

namespace Negocios {
    public class ProductoReport {
        public List<Entidades.Producto> ListObj { get; set; }

        public object CreateReport() {
            var list = new Datos.Producto();
            var result = list.Mostrar();
            _ = result.Tables[0].Columns.Count;

            ListObj = new List<Entidades.Producto>();
            foreach(System.Data.DataRow rows in result.Tables[0].Rows) {
                var ObjModel = new Entidades.Producto() {
                    IdProducto = Convert.ToInt32(rows[0]),
                    DescProducto = Convert.ToString(rows[1]),
                    NombreFabricante = Convert.ToString(rows[2]),
                    Costo = Convert.ToSingle(rows[3]),
                    Precio = Convert.ToSingle(rows[4]),
                    Cantidad = Convert.ToInt32(rows[5])
                };
                ListObj.Add(ObjModel);
            }
            return ListObj;
        }
    }
}

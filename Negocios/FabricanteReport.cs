using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class FabricanteReport
    {
        public List<Entidades.Fabricante> ListObj { get; set; }

        public object CreateReport()
        {
            var list = new Datos.Fabricante();
            var result = list.Mostrar();

            var i = result.Tables[0].Columns.Count;
            ListObj = new List<Entidades.Fabricante>();
            foreach (System.Data.DataRow rows in result.Tables[0].Rows)
            {
                var ObjModel = new Entidades.Fabricante()
                {
                    IdFabricante = Convert.ToInt32(rows[0]),
                    NombreFabricante = Convert.ToString(rows[1]),
                    Direccion = Convert.ToString(rows[2]),
                    Pais = Convert.ToString(rows[3])

                };
                ListObj.Add(ObjModel);
            }
            return ListObj;
        }
    }
}

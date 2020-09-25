using System;
using System.Collections.Generic;

namespace Negocios {
    public class ClienteReport {
        public List<Entidades.Cliente> Clientes { get; set; }


        public object CreateReport() {
            var listCliente = new Datos.Cliente();
            var result = listCliente.Mostrar();

            var i = result.Tables[0].Columns.Count;
            Clientes = new List<Entidades.Cliente>();
            foreach(System.Data.DataRow rows in result.Tables[0].Rows) {
                var ClienteModel = new Entidades.Cliente() {
                    IdCliente = Convert.ToInt32(rows[0]),
                    NombreCliente = Convert.ToString(rows[1]),
                    Direccion = Convert.ToString(rows[2]),
                    Pais = Convert.ToString(rows[3]),
                    SaldoInicial = Convert.ToSingle(rows[4]),
                    SaldoActual = Convert.ToSingle(rows[5]),
                    Estatus = Convert.ToByte(rows[6])

                };
                Clientes.Add(ClienteModel);
            }
            return Clientes;
        }
    }
}

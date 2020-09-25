using System.Data;

namespace Negocios {
    public class Cliente {
        Datos.Cliente obj;
        public System.Data.DataSet Mostrar() {
            obj = new Datos.Cliente();
            return obj.Mostrar();
        }

        public bool ValidarRecord(int id) {
            obj = new Datos.Cliente();
            return obj.ValidarRecord(id);
        }
        public DataTable Buscar(int id) {
            obj = new Datos.Cliente();
            return obj.Buscar(id);
        }
        public void Registrar(Entidades.Cliente entidad) {
            obj = new Datos.Cliente();
            obj.Registrar(entidad);
        }
        public void Actualizar(Entidades.Cliente entidad) {
            obj = new Datos.Cliente();
            obj.Actualizar(entidad);
        }
        public void Eliminar(int id) {
            obj = new Datos.Cliente();
            obj.Eliminar(id);
        }
        public void Inhabilitar(Entidades.Cliente entidad) {
            obj = new Datos.Cliente();
            obj.Inhabilitar(entidad);
        }

        public DataTable MostrarBuscar(string textBuscar) {
            obj = new Datos.Cliente();
            return obj.MostrarBuscar(textBuscar);
        }

        //public bool InscertarEditar(string id, string nombre, string direccion, string pais, string saldoInic, string saldoAct, string estatus)
        //{
        //    cliente = new Datos.Cliente();
        //    return cliente.InsertarEditar(Convert.ToInt32(id), nombre, direccion, pais, Convert.ToDecimal(saldoInic), saldoAct, Convert.ToByte(estatus));
        //}
    }
}

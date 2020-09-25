using System.Data;

namespace Negocios {
    public class Producto {
        Datos.Producto obj;
        public System.Data.DataSet Mostrar() {
            obj = new Datos.Producto();
            return obj.Mostrar();
        }

        public System.Data.DataSet BuscarRecord(string parametro) {
            obj = new Datos.Producto();
            return obj.BuscarRecord(parametro);
        }

        public bool ValidarRecord(int id) {
            obj = new Datos.Producto();
            return obj.ValidarRecord(id);
        }
        public System.Data.DataTable Buscar(int id) {
            obj = new Datos.Producto();
            return obj.Buscar(id);
        }
        public void Registrar(Entidades.Producto entidad) {
            obj = new Datos.Producto();
            obj.Registrar(entidad);
        }
        public void Actualizar(Entidades.Producto entidad) {
            obj = new Datos.Producto();
            obj.Actualizar(entidad);
        }
        public void Eliminar(int id) {
            obj = new Datos.Producto();
            obj.Eliminar(id);
        }

        public DataTable MostrarBuscar(string textBuscar) {
            obj = new Datos.Producto();
            return obj.MostrarBuscar(textBuscar);
        }

    }
}

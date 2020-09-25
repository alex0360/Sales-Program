namespace Negocios {
    public class Vendedor {
        Datos.Vendedor obj;
        public System.Data.DataSet Mostrar() {
            obj = new Datos.Vendedor();
            return obj.Mostrar();
        }
        public System.Data.DataSet BuscarRecord(string parametro) {
            obj = new Datos.Vendedor();
            return obj.BuscarRecord(parametro);
        }
        public bool ValidarRecord(int id) {
            obj = new Datos.Vendedor();
            return obj.ValidarRecord(id);
        }
        public void Registrar(Entidades.Vendedor entidad) {
            obj = new Datos.Vendedor();
            obj.Registrar(entidad);
        }
        public void Actualizar(Entidades.Vendedor entidad) {
            obj = new Datos.Vendedor();
            obj.Actualizar(entidad);
        }
        public void Eliminar(int id) {
            obj = new Datos.Vendedor();
            obj.Eliminar(id);
        }

        public System.Data.DataTable Buscar(int id) {
            obj = new Datos.Vendedor();
            return obj.Buscar(id);
        }

        public System.Data.DataTable MostrarBuscar(string textBuscar) {
            obj = new Datos.Vendedor();
            return obj.MostrarBuscar(textBuscar);
        }
    }
}

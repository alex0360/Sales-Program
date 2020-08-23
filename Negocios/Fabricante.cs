using System.Data;

namespace Negocios
{
    public class Fabricante
    {
        Datos.Fabricante obj;
        public System.Data.DataSet Mostrar()
        {
            obj = new Datos.Fabricante();
            return obj.Mostrar();
        }

        public System.Data.DataSet BuscarRecord(string parametro)
        {
            obj = new Datos.Fabricante();
            return obj.BuscarRecord(parametro);
        }

        public bool ValidarRecord(int id)
        {
            obj = new Datos.Fabricante();
            return obj.ValidarRecord(id);
        }
        public DataTable Buscar(int id)
        {
            obj  = new Datos.Fabricante();
            return obj.Buscar(id);
        }
        public void Registrar(Entidades.Fabricante entidad)
        {
            obj = new Datos.Fabricante();
            obj.Registrar(entidad);
        }
        public void Actualizar(Entidades.Fabricante entidad)
        {
            obj = new Datos.Fabricante();
            obj.Actualizar(entidad);
        }
        public void Eliminar(int id)
        {
            obj = new Datos.Fabricante();
            obj.Eliminar(id);
        }
    }
}

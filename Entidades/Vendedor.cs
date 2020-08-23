namespace Entidades
{
    public class Vendedor
    {
        //ID_VENDEDOR int no	4
        //NOMB_VENDEDOR varchar no	45
        //ID_JEFE int no	4
        //OFICINA varchar no	20
        //COMISION float no	8

        public int IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public int? IdJefe { get; set; }
        public string Oficina { get; set; }
        public float Comision { get; set; }
    }
}

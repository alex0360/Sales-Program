namespace Entidades {
    public class Cliente {
        //ID_CLIENTE int no	4
        //NOMB_CLIENTE varchar no	45
        //DIRECCION varchar no	60
        //PAIS varchar no	20
        //SALDO_INIC float no	8
        //SALDO_ACT float no	8
        //Estatus bit no	1

        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Pais { get; set; }
        public float SaldoInicial { get; set; }
        public float SaldoActual { get; set; }
        public byte Estatus { get; set; }

    }
}

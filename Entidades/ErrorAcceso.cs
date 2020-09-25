using System;

namespace Entidades {
    public class ErrorAcceso {
        //IdRegistro int no	4
        //usuario varchar no	15
        //fecha datetime    no	8

        public int IdRegistro { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}

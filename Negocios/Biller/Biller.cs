using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public static class Biller
    {
        public static string GenerateInvoice(string value, int startIndex = 1, int length = 6)
        {
            return Negocios.Encriptacion.MD5(value).Substring(startIndex, length);
        }
    }
}
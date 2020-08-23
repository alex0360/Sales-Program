using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Impresora
    {
        public Impresora()
        {
            InstalledPrinters();
        }

        public List<string> impresoraDisponible = new List<string>();

        private void InstalledPrinters()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                impresoraDisponible.Add(pkInstalledPrinters);
            }
        }
    }
}

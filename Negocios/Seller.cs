using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Negocios
{
    public class Seller
    {
        public Negocios.Venta SaleBusiness;
        public Entidades.Venta SaleEntity;
        readonly IEnumerable<Control> _control;
        readonly DataGridView _dataGridView;

        public Seller(IEnumerable<Control> control, DataGridView dataGridView)
        {
            _control = control;
            _dataGridView = dataGridView;

            if(SaleBusiness == null)
            {
                SaleBusiness = new Negocios.Venta();
            }

            if(SaleEntity == null)
            {
                SaleEntity = new Entidades.Venta();
            }
        }

        public void Post(string invoice)
        {
            try
            {
                if(_dataGridView.Rows.Count > 0)
                    {
                        SaleEntity.Factura = invoice;
                        SaleEntity.Fecha = DateTime.Now;
                        SaleEntity.IdCliente = int.Parse(_control.First(x => x.Name == SellerControl.Client_Text_Box).Text);
                        SaleEntity.IdVendedor = int.Parse(_control.First(x => x.Name == SellerControl.Seller_Text_Box).Text);

                        for(int i = 0; i <= _dataGridView.Rows.Count - 1; i++)
                        {
                            SaleEntity.IdProduccto = Convert.ToInt16(_dataGridView.Rows[i].Cells[0].Value.ToString());
                            SaleEntity.Cantidad = Convert.ToInt16(_dataGridView.Rows[i].Cells[2].Value.ToString());

                            SaleBusiness.InsertarVentas(SaleEntity);
                        }
                    }
            }
            catch(ArgumentNullException argmentNull)
            {
                 throw new ArgumentNullException($"Parametro: {argmentNull.ParamName}, Mensaje: {argmentNull.Message}");
            }
            catch(InvalidOperationException invalidOperation)
            {
                throw new InvalidOperationException($"Invalid Operation: + {invalidOperation.Message}");
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace Course.OOP.Encapsulation.Business
{
    public class Invoice
    {

        private List<InvoiceItem> items;

        public Invoice() {
            items = new List<InvoiceItem>();
        }
        
        /**Acceso en la libreria actual y en clases hijas*/
        protected internal decimal CalculateTotal() {

            decimal result = 0;
            foreach (InvoiceItem item in items) {
                result += item.Amount;
            }

            return result;
        }

        /**visible en clases hijas, solo si están en el misma librería.
           Disponible desde C# 7.2
             */
        private protected decimal OtherMethod() {
            decimal result = CalculateTotal() / 10;
            return result;
        }

    }
}

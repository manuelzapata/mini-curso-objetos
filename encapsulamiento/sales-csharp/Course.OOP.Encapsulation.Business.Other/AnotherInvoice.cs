using System;

namespace Course.OOP.Encapsulation.Business.Other
{
    class AnotherInvoice: Invoice
    {
        void MyMethod() {
            decimal result = this.CalculateTotal();
            //Si descomentas la siguiente verás que el método no se puede acceder.
            //this.OtherMethod();
        }
    }
}

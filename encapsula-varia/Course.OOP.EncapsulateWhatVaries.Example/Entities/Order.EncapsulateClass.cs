using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.EncapsulateWhatVaries.Example.Entities
{
    public class OrderEncapsulateClass
    {

        /// <summary>
        /// Persona que está haciendo la compra.
        /// </summary>
        public Customer Buyer { get; set; }

        public decimal TotalAmount { get; set; }

        public void Save()
        {

            bool orderSaved = true;
            //Lógica de negocio para validar y guardar la orden.
            if (CheckInventory())
            {
                //Pasos adicionales.

                //
            }

            if (orderSaved)
            {
                //Una vez la orden se haya guardado, se va a notificar al cliente.
                var notifier = new CustomerNotifier();
                notifier.Send(Buyer);
            }

        }

        private bool CheckInventory()
        {
            //lógica de negocio para validar la orden.
            return true;
        }

    }
}

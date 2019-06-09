using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.EncapsulateWhatVaries.Example.Entities
{

    /*
     * Ejemplo aplicando la encapsulación por método.
     * **/
    public class OrderEncapsulateMethod
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
                SendEmail();
            }

        }

        private void SendEmail() {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sistemas de compras", "sistema@compras.com"));
            message.To.Add(new MailboxAddress(Buyer.FirstName, Buyer.Email));
            message.Subject = "Compra confirmada";

            message.Body = new TextPart("plain")
            {
                Text = "Hola, la compra ha sido confirmada."
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.compras.com", 587, false);
                client.Send(message);
                client.Disconnect(true);
            }
        }

        private bool CheckInventory()
        {
            //lógica de negocio para validar la orden.
            return true;
        }

    }
}

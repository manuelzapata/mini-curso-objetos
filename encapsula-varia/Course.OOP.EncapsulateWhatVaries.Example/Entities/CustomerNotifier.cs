using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.EncapsulateWhatVaries.Example.Entities
{
    public class CustomerNotifier
    {

        public void Send(Customer customer)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sistemas de compras", "sistema@compras.com"));
            message.To.Add(new MailboxAddress(customer.FirstName, customer.Email));
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

    }
}

using RazorPagesMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace RazorPagesMovie.Services
{
    public class SmtpMailService : IMailService
    {
        public async Task Send(Message message)
        {
            using (var smtp = new SmtpClient())
            {
                //ok: smtp.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                //ok: smtp.PickupDirectoryLocation = @"c:\maildrop";

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 25;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("rdemagri", "dummy123");
                smtp.EnableSsl = true;

                var msg = new MailMessage
                {
                    Body = message.Body,
                    Subject = message.Subject,
                    From = new MailAddress(message.From)
                };
                msg.To.Add(message.To);
                try
                {
                    await smtp.SendMailAsync(msg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            };
        }
    }
}


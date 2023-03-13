using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Services
{
    public class EmailService : IEmailService
    {
        
        public bool SendEmail(Email emailConfig)
        {
            try
            {

                string host = emailConfig.Host;
                string display = emailConfig.Display;
                string username = emailConfig.Username;
                string password = emailConfig.Password;
                int port = emailConfig.Port;
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(username, display)
                };

                mail.To.Add(emailConfig.Clients);
                mail.Subject = emailConfig.Subject;
                mail.Body = emailConfig.Message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(host, port))
                {

                    smtp.Credentials = new NetworkCredential(username, password);
                    smtp.EnableSsl = true;

                    try
                    {
                        smtp.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao enviar email. Motivo: " + ex.Message);
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exc: " + ex.Message);
                return false;
            }
            return true;
        }
    }
}

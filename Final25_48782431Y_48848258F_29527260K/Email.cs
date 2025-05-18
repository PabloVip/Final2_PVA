using System.Net;
using System.Net.Mail;

namespace Final25_48782431Y_48848258F_29527260K
{
    public class Email
    {
        private const string EmailDeGmail = "micuenta@gmail.com";
        private const string NombreDeOrigen = "PAYAVI SOLAR";
        private const string PasswordGmail = "Password";


        public static void EmailPorGmail(string nombreDestinatario, string emailDestinatario, 
            string asunto, string mensaje, bool esMensajeHtml = false)
        {
            var fromAddress = new MailAddress(EmailDeGmail, NombreDeOrigen);
            var toAddress = new MailAddress(emailDestinatario, nombreDestinatario);
            var fromPassword = PasswordGmail;
            var subject = asunto;
            var body = mensaje;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
               Subject = subject,
               Body = body,
               IsBodyHtml = esMensajeHtml
            })
            {
                smtp.Send(message);
            }
        }
    }
}
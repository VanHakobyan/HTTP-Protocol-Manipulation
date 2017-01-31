using System.Net;
using System.Net.Mail;

namespace HTTPProtocolAnalyzer
{
    public class EmailService
    {
        public  void ContactClient(string message)
        {
            MailMessage msg = new MailMessage("vanhakobyan1996@gmail.com", "htvano1996@gmail.com", "error", message);
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("vanhakobyan1996@gmail.com", "VAN606580");
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
        }
    }
}

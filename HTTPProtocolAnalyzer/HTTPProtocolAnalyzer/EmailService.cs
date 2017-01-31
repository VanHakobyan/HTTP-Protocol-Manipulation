using System.IO;
using System.Net;
using System.Net.Mail;

namespace HTTPProtocolAnalyzer
{
    public class EmailService
    {
        public  void ContactClient(string message)
        {
            string[] lines =File.ReadAllLines(@"D:\test.txt");
            for (int i = 0; i <lines.Length; i++)
            {
                MailMessage msg = new MailMessage("myemail@gmail.com", lines[i], "HACKED", message);
                msg.IsBodyHtml = true;
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.UseDefaultCredentials = false;
                NetworkCredential cre = new NetworkCredential("myemail@gmail.com", "pasword");
                sc.Credentials = cre;
                sc.EnableSsl = true;
                sc.Send(msg);
            }
            
        }
    }
}

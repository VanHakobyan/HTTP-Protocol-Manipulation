using System;
using System.Threading;

namespace HTTPProtocolAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"D:\text.txt";
            var link = new LinkWriter(path);
            link.linkSaver("https://e.mail.ru/message/13880712950000000966/");

            link.Dispose(); //solution suggested by Aram Zhamkochyan

            Console.WriteLine("first step");
            Thread.Sleep(1000);
            MailExtracter.ExtractEmails(@"D:\text.txt", @"D:\test.txt");
            Console.WriteLine("second step");

            EmailService ES = new EmailService();
            ES.ContactClient("your HACKED");
            
        }
    }
}

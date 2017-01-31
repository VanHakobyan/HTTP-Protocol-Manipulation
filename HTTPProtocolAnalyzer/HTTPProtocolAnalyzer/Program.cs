namespace HTTPProtocolAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"D:\text.txt";
            var link = new LinkWriter(path);
            link.linkSaver("https://mail.ru/");
            MailExtracter.ExtractEmails(@"D:\text.txt", @"D:\test.txt");

        }
    }
}

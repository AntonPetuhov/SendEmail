using System;
using System.Net;
using System.Net.Mail;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // кто отправляет
            MailAddress From = new MailAddress("anton.petuhov@fccho-moscow.ru", "Anton");
            // кому отправляем
            MailAddress To = new MailAddress("anton.petuhov@fccho-moscow.ru");

            // создается объект сообщения
            MailMessage mail = new MailMessage(From, To);
            mail.Subject = "Test";

            // текст письма
            //mail.Body = "<h2>Test e-mail test</h2>";
            mail.Body = "Test e-mail test";

            // письмо представляет код html
            // mail.IsBodyHtml = true;

            // адрес smtp-сервера
            SmtpClient smtp = new SmtpClient("hub01.fccho-moscow.ru");

            smtp.Send(mail);
            Console.Read();

        }

    }
}

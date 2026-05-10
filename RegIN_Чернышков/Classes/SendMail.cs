using System.Net;
using System.Net.Mail;

namespace RegIN_Чернышков.Classes
{
    public class SendMail
    {
        public static void SendMessage(string message, string to)
        {
            var smtpClient = new SmtpClient("smtp.yandex.ru")
            {
                Port = 587,
                Credentials = new NetworkCredential("yandex@yandex.ru", "fllolhdghwbfgtyp"),
                EnableSsl = true
            };

            smtpClient.Send("kotboris140107@yandex.ru", to, "Проект RegIn", message);
        }
    }
}
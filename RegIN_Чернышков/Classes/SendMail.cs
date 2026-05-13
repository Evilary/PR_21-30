using System.Net;
using System.Net.Mail;

namespace RegIN_Чернышков.Classes
{
    public class SendMail
    {
        public static void SendMessage(string message, string to)
        {
            var from = "kotboris140107@yandex.ru";
            var appPassword = "dsgxraxqchmvfvsf";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var smtpClient = new SmtpClient("smtp.yandex.ru", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(from, appPassword),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 20000
            };

            smtpClient.Send(from, to, "Проект RegIn", message);
        }
    }
}
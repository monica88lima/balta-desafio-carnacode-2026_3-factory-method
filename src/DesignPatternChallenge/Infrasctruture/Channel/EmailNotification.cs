using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Channel
{
    public class EmailNotification : INotification
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }

        public void Send(string recipient, string subject, string body)
        {
            Console.WriteLine($"📧 Enviando Email para {Recipient = recipient}");
            Console.WriteLine($"   Assunto: {Subject = subject}");
            Console.WriteLine($"   Mensagem: {Body = body}");

        }
    }
}

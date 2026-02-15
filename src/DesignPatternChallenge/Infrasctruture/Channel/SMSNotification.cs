using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Channel
{
    public class SMSNotification: INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void Send(string recipient, string body, string subject )
        {
            Console.WriteLine($"📧 Enviando SMS para {PhoneNumber = recipient}");
            
            Console.WriteLine($"   Mensagem: {Message = subject}");

        }
    }
}

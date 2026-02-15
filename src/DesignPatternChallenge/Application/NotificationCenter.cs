using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatternChallenge.Application
{
    public class NotificationCenter 
    {
        private readonly INotificationFactory _factory;

        public NotificationCenter(INotificationFactory factory)
        {
            _factory = factory;
        }
        public void SendNotification(string recipient, string subject, string body)
        {
            var notification = _factory.CreateNotification();
            notification.Send(recipient, subject, body);
        }
        public void SendOrderConfirmation(string text, string orderNumber)
        {
            var notification = _factory.CreateNotification();
            var recipient = text;
            var subject = "Confirmação de Pedido";
            var body = $"Seu pedido {orderNumber} foi confirmado!";

            notification.Send(recipient, subject, body);

        }

        public void SendPaymentReminder(string text, decimal amount)
        {
            var notification = _factory.CreateNotification();
            var recipient = text;
            var subject = "Lembrete de Pagamento";
            var body = $"Você tem um pagamento pendente de R$ {amount:N2}";

            notification.Send(recipient, subject, body);
        }

        public void SendShippingUpdate(string text, string trackingCode)
        {
            var notification = _factory.CreateNotification();
            var recipient = text;
            var subject = "Pedido Enviado";
            var body = $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}!";

            notification.Send(recipient, subject, body);

        }

    }
}

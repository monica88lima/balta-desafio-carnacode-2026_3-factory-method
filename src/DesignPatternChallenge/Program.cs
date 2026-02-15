// See https://aka.ms/new-console-template for more information
using DesignPatternChallenge;
using DesignPatternChallenge.Infrasctruture.Factory;

Console.WriteLine("=== Sistema de Notificações ===\n");

//INotificationFactory factory = new EmailNotificationFactory();

//var center = new NotificationCenter(factory);
//center.SendOrderConfirmation("email@gmail.com", "12345");
//center.SendPaymentReminder("email@gmail.com", 99.99m);
//center.SendShippingUpdate("email@gmail.com", "8453457457");


INotificationFactory factory2 = new SMSNotificationFactory();

var center2 = new NotificationCenter(factory2);
center2.SendOrderConfirmation("9999-88833", "98765");
center2.SendPaymentReminder("9999-88833", 49.99m);
center2.SendShippingUpdate("9999-88833", "1234567890");
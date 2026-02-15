using DesignPatternChallenge.Application;
using DesignPatternChallenge.Infrasctruture.Channel;

namespace DesignPatternChallenge.Infrasctruture.Factory
{
    public class EmailNotificationFactory : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}

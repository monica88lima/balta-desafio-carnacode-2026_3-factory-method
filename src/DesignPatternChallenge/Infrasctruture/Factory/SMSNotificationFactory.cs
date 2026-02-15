namespace DesignPatternChallenge.Infrasctruture.Factory
{
    public class SMSNotificationFactory: INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new SMSNotification();   
        }
      

    }
}

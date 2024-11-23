using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public interface INotificationSender
    {
        void SendNotification(string message);
    }
    //Concrete Implementations for the Products
    public class EmailNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending EMAIL notification: {message}");
            // Logic to send email here...
        }
    }
    public class SMSNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS notification: {message}");
            // Logic to send SMS here...
        }
    }
    public class PushNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending PUSH notification: {message}");
            // Logic to send push notification here...
        }
    }
    //Factory Class to Produce the Products
    public static class NotificationFactory
    {
        public static INotificationSender CreateNotificationSender(string type)
        {
            switch (type.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SMSNotification();
                case "push":
                    return new PushNotification();
                default:
                    throw new ArgumentException("Invalid notification type");
            }
        }
    }
}

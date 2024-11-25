using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.SolidPrinciples
{
    /*
     * Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification."
     * 
     * You should be able to add new functionality to a class without modifying its existing code.
     */


    //Before Oprinciple
    public class NotificationService1
    {
        public void Notify(string message, string notificationType)
        {
            if (notificationType == "Email")
            {
                Console.WriteLine($"Sending Email: {message}");
            }
            else if (notificationType == "SMS")
            {
                Console.WriteLine($"Sending SMS: {message}");
            }
        }
    }




    //After applying O
    // Step 1: Define an abstraction for notifications
    public interface INotification
    {
        void Send(string message);
    }

    // Step 2: Implement specific notification types
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }

    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    // Step 3: NotificationService now depends on the abstraction
    public class NotificationService
    {
        private readonly List<INotification> _notifications = new();

        public void AddNotification(INotification notification)
        {
            _notifications.Add(notification);
        }

        public void NotifyAll(string message)
        {
            foreach (var notification in _notifications)
            {
                notification.Send(message);
            }
        }
    }

    class OPrincipleProgram
    {
        static void Main()
        {
            var service = new NotificationService();
            service.AddNotification(new EmailNotification());
            service.AddNotification(new SMSNotification());

            service.NotifyAll("Hello, this is a notification!");
        }
    }




}

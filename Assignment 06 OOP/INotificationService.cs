using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP
{
    internal interface INotificationService
    {
        public string SendNotification(string recipient, string message);
    }

    

    internal class EmailNotificationService : INotificationService
    {
        public string SendNotification(string recipient, string message)
        {
            return $" Email: Hello {recipient} , message : {message}";
        }
    }

    internal class SmsNotificationService : INotificationService
    {
        public string SendNotification(string recipient, string message)
        {
            return $" Sms: Hello {recipient} , message : {message}";
        }
    }

    internal class PushNotificationService : INotificationService
    {
        public string SendNotification(string recipient, string message)
        {
            return $"  Hello {recipient} , message : {message}";
        }
    }
}

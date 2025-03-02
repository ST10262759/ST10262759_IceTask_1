using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10262759_IceTask1
{
    public class NotificationFactory
    {
        public static INotification CreateNotification(string channel)
        {
            switch (channel.ToUpper())
            {
                case "EMAIL":
                    return new EmailNotification();
                case "SMS":
                    return new SMSNotification();
                case "PUSH":
                    return new PushNotification();
                default:
                    throw new ArgumentException($"Unkown notification channel:{channel}");

            }
        }
    }
}

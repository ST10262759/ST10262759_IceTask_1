using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10262759_IceTask1
{
    public class PushNotification : INotification
    {
        public string Send(string recipient, string message)
        {
            Console.WriteLine($"Sending PUSH notification to device {recipient}: {message}");
           
            return $"Push notification sent to {recipient}";
        }
    }
}

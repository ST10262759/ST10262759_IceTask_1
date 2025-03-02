using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10262759_IceTask1
{
    public  class SMSNotification : INotification
    {
        public String Send(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
            
            return $"SMS sent to {recipient}";
        }
    }
}

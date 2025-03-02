using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10262759_IceTask1
{
    public class EmailNotification : INotification
    {
        public string Send(string recipient, string message)
        {
            Console.WriteLine($"Sending EMAIL to {recipient}: {message}");
            
            return $"Email sent to {recipient}";
        }
    }
}

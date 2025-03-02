namespace ST10262759_IceTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern Demonstration = Notification System");
            Console.WriteLine("------------------------------------------------");

            //Email
            INotification emailNotification = NotificationFactory.CreateNotification("email");
            emailNotification.Send("user@example.com", "Your account has been created!");

            //SMS
            INotification smsNotification = NotificationFactory.CreateNotification("sms");
            smsNotification.Send("+1234567890", "Your verification code is 123456");

            //Push Notification
            INotification pushNotification = NotificationFactory.CreateNotification("push");
            pushNotification.Send("device_token_123", "New message received");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

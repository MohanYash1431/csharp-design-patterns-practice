using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class SmsNotification : INotification
    {
        public void send(string message)
        {
            Console.WriteLine($"Sending SMS notification: {message}");
        }
    }
}

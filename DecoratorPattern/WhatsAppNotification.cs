using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class WhatsAppNotification : INotification
    {
        public void send(string message)
        {
            Console.WriteLine($"Sending WhatsApp notification: {message}");
        }
    }
}

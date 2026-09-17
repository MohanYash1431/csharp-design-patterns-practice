using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class RetryNotification : NotificationDecorator
    {
        public RetryNotification(INotification notification) : base(notification)
        {
        }

        public override void send(string message)
        {
            Console.WriteLine("Retrying notification...");

            _notification.send(message);
        }

    }
}

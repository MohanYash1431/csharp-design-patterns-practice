using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class NotificationDecorator : INotification
    {
        protected readonly INotification _notification;
        public NotificationDecorator(INotification notification)
        {
            _notification = notification;
        }
        public abstract void send(string message);
    }
}

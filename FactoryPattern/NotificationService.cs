using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NotificationService
    {
        public void SendNotification(string type, string message)
        {
            INotification notification = NotificationFactory.Create(type);

            notification.Send(message);
        }
    }
}

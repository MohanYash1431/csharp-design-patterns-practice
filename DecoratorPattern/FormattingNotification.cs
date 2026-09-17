using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FormattingNotification : NotificationDecorator
    {
        public FormattingNotification(INotification notification) : base(notification)
        {
            
        }
        public override void send(string message)
        {
            string formattedMessage = $"*** {message} ***";
            _notification.send(formattedMessage);
        }
    }
}

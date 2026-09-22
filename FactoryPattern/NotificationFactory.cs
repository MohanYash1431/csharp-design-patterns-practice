using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class NotificationFactory
    {
        public static INotification Create(string type)
        {
            if (string.Equals(type, "SMS",
                StringComparison.OrdinalIgnoreCase))
            {
                return new SmsNotification();
            }

            if (string.Equals(type, "Slack",
                StringComparison.OrdinalIgnoreCase))
            {
                return new SlackNotification();
            }

            throw new ArgumentException(
                $"Unsupported notification type: {type}",
                nameof(type));
        }
    }
}

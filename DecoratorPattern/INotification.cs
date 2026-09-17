using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public interface INotification
    {
        void send(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Amol : ISubscriber
    {
        public void NotifyMe(string videoId)
        {
            Console.WriteLine($"Amol : New video uploaded - {videoId}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Ananya : ISubscriber
    {
        public void NotifyMe(string videoId)
        {
            Console.WriteLine($"Ananya : new video uploaded {videoId}");
        }
    }
}

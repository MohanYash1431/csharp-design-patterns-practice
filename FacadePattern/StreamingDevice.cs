using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class StreamingDevice
    {
        public void On()
        {
            Console.WriteLine("StreamingDevice is ON");
        }

        public void playMovie(string movieName)
        {
            Console.WriteLine($"StreamingDevice is playing {movieName}");
        }
    }
}

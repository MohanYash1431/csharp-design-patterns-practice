using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("TV is ON");
        }

        public void SetInPut()
        {
            Console.WriteLine($"TV input set to HDMI");
        }
    }
}

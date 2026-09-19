using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class SoundSystem
    {
        public void On()
        {
            Console.WriteLine("SoundSystem is ON");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"SoundSystem volume set to {level}");
        }
    }
}

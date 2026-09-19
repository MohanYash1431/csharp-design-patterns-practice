using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        private readonly TV _tv;
        private readonly SoundSystem _soundSystem;

        private readonly StreamingDevice _streamingDevice;

        public HomeTheaterFacade()
        {
            _tv = new TV();
            _soundSystem = new SoundSystem();
            _streamingDevice = new StreamingDevice();
        }

        public void WatchMovie(string movieName)
        {
            _tv.On();
            _tv.SetInPut();

            _soundSystem.On();
            _soundSystem.SetVolume(50);

            _streamingDevice.On();
            _streamingDevice.playMovie(movieName);
        }
    }
}

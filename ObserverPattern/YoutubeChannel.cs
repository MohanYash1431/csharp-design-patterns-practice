using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class YoutubeChannel
    {
        private readonly List<ISubscriber> _subscribers;

        public YoutubeChannel()
        {
            _subscribers = new List<ISubscriber>();
        }   

        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void UploadVideo(string videoId)
        {
            Console.WriteLine($"YoutubeChannel : new video uploaded {videoId}");

            NotifySubscribers(videoId);
        }

        public void NotifySubscribers(string videoId)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.NotifyMe(videoId);
            }
        }
    }
}

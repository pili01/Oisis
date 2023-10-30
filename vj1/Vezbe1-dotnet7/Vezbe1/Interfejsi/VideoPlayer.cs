using System;
using System.Threading;

namespace Nasledjivanje
{
    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video ...");
            Thread.Sleep(500);
        }

        public void Stop()
        {
            Console.WriteLine("Stopping video ...");
        }

        public void Pause()
        {
            Console.WriteLine("Paused ....");
            Thread.Sleep(500);
            Console.WriteLine("nastavak...");
        }
    }
}
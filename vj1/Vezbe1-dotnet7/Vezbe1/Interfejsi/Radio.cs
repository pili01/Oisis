using System;
using System.Threading;

namespace Nasledjivanje
{
    public class Radio : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Radio ...");
            Thread.Sleep(1500);
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Radio ...");
            Thread.Sleep(1500);
        }

        public void Pause()
        {
            Console.WriteLine("Paused ....");
            Thread.Sleep(500);
            Console.WriteLine("nastavak...");
        }
    }
}
using System;
using System.Collections.Generic;

namespace Nasledjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primer 1
            IPlayable radio = new Radio();
            IPlayable videoPlayer = new VideoPlayer();
            
            radio.Play();
            radio.Stop();
            
            videoPlayer.Play();
            videoPlayer.Stop();

            // Primer 2
            Radio testRadio = new Radio();
            VideoPlayer testVideoPlayer = new VideoPlayer();
            List<IPlayable> players = new() { testRadio, testVideoPlayer };
            // Nije bitno sta je u listi, bitno je da implementira Playable interfejs
            foreach (IPlayable player in players)
            {
                player.Play();
                player.Stop();
            }
            
            // zadatak 3 dodati metodu Pause u intefejs i implementiati na odgovarajucim mestima i pozvati ispod.

        }
    }
}
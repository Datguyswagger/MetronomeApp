using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MetronomeApp
{
    internal class Tempo
    {
        // I need to make a Timing class and need to figure out how they work.
        Stopwatch baseTime = new Stopwatch();
        DispatcherTimer metronomeTime = new DispatcherTimer();
        private bool metStart;
        private bool running;
        private int metTempo;

        public bool MetStart
        {
            get => metStart;
            set => metStart = value;
        }

        public int MetTempo
        {
            get => metTempo;
            set => metTempo = value;
        }
        public Tempo() 
        {
            metStart = false;
            running = false; 
        }

        public void metronomePlayTest()
        {
            // Starts the metronome
            metronomeTime.Start();
            metronomeTime.Interval = TimeSpan.FromMilliseconds(500);
            metronomeTime.Tick += new EventHandler(sound_test);
            running = true; 
        }

        public void metronomeStopTest()
        {
            // Stops the metronome, alledgedly
            metronomeTime.IsEnabled = false;
             metronomeTime.Stop();
            metronomeTime.Tick -= sound_test;
            running = false;
        }

        public void sound_test(object sender, EventArgs e)
        {
            // Starts the sound of the metronome
           if(running) SystemSounds.Beep.Play();
        }

    }
}

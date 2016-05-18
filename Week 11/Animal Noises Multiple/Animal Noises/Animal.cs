using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private String soundFileName;
        string sharedValue;

        public Animal(String soundFileName, string sharedValue)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.sharedValue = sharedValue;
        }

        public void speak()
        {
            while (true)
            {
                lock (sharedValue)
                {
                    soundPlayer.Play();
                    Thread.Sleep(500);
                }
            }
        }

    }
}

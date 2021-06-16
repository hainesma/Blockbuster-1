using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{

    
    //Always make classes, properties public unless to do otherwise
    public class VHS : IPlay
    {
        public int CurrentTime { get; set; } = 0;
        public void Rewind()
        {
            CurrentTime = 0;
        }

        //VHS wants it own version of the play method 
        public void Play(List<string> Scenes)
        {
            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine(scene);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }
        }
    }
}

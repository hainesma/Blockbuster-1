using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    public class DVD : IPlay
    {
        
        public void Play(List<string> Scenes)
        {
            Console.WriteLine($"Select what scene you'd like to watch: 0 to {Scenes.Count-1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            string scene = Scenes[index];
            Console.WriteLine(scene);

        }
    }
}

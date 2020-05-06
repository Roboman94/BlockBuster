using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster
{
    class VHS : MovieAbs
    {
        

        public int currentTime { get; set; } = 0;

        public VHS(string title, string category, int runtime, List<string> scenes)
            : base(title, category, runtime, scenes)
        {
        
        }

        public override void Play()
        {
            foreach (string scenez in Scenes)
            {
            string scene = Scenes[currentTime];
                Console.WriteLine(scene);
                currentTime++;
            }
        }

        public void Rewind()
        {
            currentTime = 0;


        }


    }
        
}

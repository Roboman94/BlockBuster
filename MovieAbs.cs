using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster
{
    abstract class MovieAbs
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public MovieAbs(string title, string category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            Runtime = runtime;
            Scenes = scenes;

        }

        public abstract void Play();
       
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {Runtime}");
        }

        public void PrintScenes()
        {
            int i = 0;
            foreach(string scene in Scenes)
            {
                Console.WriteLine($"{i+1} : {scene}");
                i++;
            }
        }


    }
}

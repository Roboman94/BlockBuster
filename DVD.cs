using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster
{
    class DVD : MovieAbs
    {

        public DVD(string title, string category, int runtime, List<string> scenes)
            : base(title, category, runtime, scenes)
        {

        }

      

        public override void Play()
        {
            int cont = 0;
            while (cont == 0)
            {
                PrintScenes();
                Console.WriteLine("Select scene ");
                string input = Console.ReadLine();
                int pick = int.Parse(input);
                if (pick <= Scenes.Count)
                {
                    foreach (string scenez in Scenes)
                    {
                        if (pick <= Scenes.Count)
                        {
                            string scene = Scenes[pick - 1];
                            Console.WriteLine(scene);
                            pick++;

                        }
                    }
                }
                Console.WriteLine("Watch another scene? (y/n)");
                input = Console.ReadLine();
                if (input == "y")
                {
                    cont = 0;
                }
                else cont = 1;
            }
            Console.WriteLine("Bye!");
        }

    }
  

}

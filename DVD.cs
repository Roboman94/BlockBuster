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
            int valid = 0;
            string input = "";
            int pick = 0;
            while (cont == 0)
            {
                valid = 0;
                while (valid == 0)
                {
                    PrintScenes();
                    Console.WriteLine("Select scene ");
                     input = Console.ReadLine();
                    try
                    {
                         pick = 0;
                        pick = int.Parse(input);
                        valid = 1;
                        cont = 0;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please try again ");
                        valid = 0;
                    }
                }
                if (pick <= Scenes.Count)
                {
                    foreach (string scenez in Scenes)
                    {
                        try
                        {
                            string scene = Scenes[pick - 1];
                            Console.WriteLine(scene);
                            pick++;
                        }
                        catch(ArgumentException)
                        {
                            break;
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

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace BlockBuster
{
    class Movie
    {
        private string name;
       
        private string type;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
      
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }


        public Movie()
        {
            name = "default";
          
            type = "default";

        }

        public Movie(string _name,  string _type)
        {
            name = _name;
          
            type = _type;

        }

        public static List<Movie> PrintMovies()
        {
            List<Movie> tasks = new List<Movie> {
            new Movie("Sandlot",  "DVD"),
            new Movie("Little Rascals",  "DVD"),
            new Movie("Lords of Dogtown",  "DVD"),
            new Movie("Holes", "VHS"),
            new Movie("Man of Steel",  "VHS"),
            new Movie("Goonies",  "VHS"),

            };
            return tasks;
        }

      

        public static string CheckOut()
        {
            List<Movie> Movies = Movie.PrintMovies();
            int ind = 1;
            foreach (Movie movie in Movies)
            {
                Console.WriteLine($"{ind}.) {movie.Name}");
                ind++;
            }
          
            Console.WriteLine("Please enter movie you wish to check out: ");
            string input = Console.ReadLine();
           // int entry = int.Parse(input);
            return input;
        }
    }
}




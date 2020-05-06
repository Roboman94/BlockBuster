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
        private string genre;
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
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
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
            genre = "default";
            type = "default";

        }

        public Movie(string _name, string _genre, string _type)
        {
            name = _name;
            genre = _genre;
            type = _type;

        }

        public static List<Movie> PrintMovies()
        {
            List<Movie> tasks = new List<Movie> {
            new Movie("Sandlot", "Comedy", "DVD"),
            new Movie("Little Rascals", "Comedy", "DVD"),
            new Movie("Lords of Dogtown", "BioPic", "DVD"),
            new Movie("Holes", "Adventure", "VHS"),
            new Movie("Man of Steel", "Action", "VHS"),
            new Movie("Goonies", "Adventure", "VHS"),

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




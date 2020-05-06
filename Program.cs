using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace BlockBuster
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to GC Blockbuster!");
            string input = Movie.CheckOut();

            #region
            if (input == "1")
            {
                List<string> VHSscenes = new List<string>();
                VHSscenes.Add("Intro");
                VHSscenes.Add("Middle");
                VHSscenes.Add("End");
                VHS v = new VHS("TheSandlot", "Comedy", 120, VHSscenes);
                v.PrintInfo();
                Console.WriteLine("Do you want to play? (y/n)");
                input = Console.ReadLine();
                if (input == "y")
                {
                    
                    v.Play();
                }

            }
            if (input == "2")
            {
                List<string> VHSscenes = new List<string>();
                VHSscenes.Add("Intro");
                VHSscenes.Add("Middle");
                VHSscenes.Add("End");
                VHS v = new VHS("Little Rascals", "Comedy", 120, VHSscenes);
                v.PrintInfo();
                Console.WriteLine("Do you want to play? (y/n)");
                input = Console.ReadLine();
                if (input == "y")
                {
                    v.Play();
                }
            }
            if (input == "3")
            {
                List<string> VHSscenes = new List<string>();
                VHSscenes.Add("Intro");
                VHSscenes.Add("Middle");
                VHSscenes.Add("End");
                VHS v = new VHS("Lords of Dogtown", "BioPic", 120, VHSscenes);
                v.PrintInfo();
                Console.WriteLine("Do you want to play? (y/n)");
                input = Console.ReadLine();
                if (input == "y")
                {
                    v.Play();
                }
            }
            if (input == "4")
            {
                List<string> DVDscenes = new List<string>();
                DVDscenes.Add("Intro");
                DVDscenes.Add("Middle");
                DVDscenes.Add("End");
                DVD v = new DVD("Holes", "Adventure", 120, DVDscenes);
                v.PrintInfo();
                Console.WriteLine("Do you want to play? (y/n)");
                input = Console.ReadLine();
                if (input == "y")
                {
                    v.Play();
                }
            }
            if (input == "5")
            {
                List<string> DVDscenes = new List<string>();
                DVDscenes.Add("Intro");
                DVDscenes.Add("Middle");
                DVDscenes.Add("End");
                DVD v = new DVD("Man of Steel", "Action", 120, DVDscenes);
                v.PrintInfo();
                Console.WriteLine("Do you want to play? (y/n)");
                input = Console.ReadLine();
                if (input == "y")
                {
                    v.Play();
                }
            }
            if (input == "6")
            {
                List<string> DVDscenes = new List<string>();
                DVDscenes.Add("Intro");
                DVDscenes.Add("Middle");
                DVDscenes.Add("End");
                DVD v = new DVD("Goonies", "Adventure", 110, DVDscenes);
                v.PrintInfo();
                Console.WriteLine("Do you want to play? (y/n)");
                input = Console.ReadLine();
                if (input == "y")
                {
                   
                    v.Play();
                }
            }
            #endregion

           

        }
    }
}
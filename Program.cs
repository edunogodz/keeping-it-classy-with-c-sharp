using System;

namespace keeping_it_classy_with_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            string name =Console.ReadLine();
            AnnounceBand(name);
            Console.WriteLine(Announce(name));
            Announce1(name);
        }

        static void AnnounceBand(String bandName)
        {
            Console.WriteLine("Welcome " + bandName + " to the stage!");
        }

        static string Announce(string venue)
        {
            return venue + " will have bands performing tonight.";        
        }

         static void Announce1(string venue)
        {
            Console.WriteLine(venue + " will have bands performing tonight.");
        }
        
    }

   
}

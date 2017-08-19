using System;
using System.Data;

namespace keeping_it_classy_with_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            Band band = new Band();
            band.Name = Console.ReadLine();
            band.Announce();

            var repeat = true; 
            while(repeat)
            {
                Console.WriteLine("Add, Announce, Quit?");
                var action = Console.ReadLine();
                if(action =="Add")
                {
                    band.AddMusician();

                }
                else if (action.StartsWith("Add"))
                {
                    var arguments = action.Split(' ');
                    if (arguments.Length == 3)
                    {
                        band.AddMusician(arguments[1],arguments[2]);
                    }
                    else{
                        band.AddMusician();
                    }
                }


                else if(action == "Announce")
                {
                    band.Announce();

                }
                else if(action == "Quit")
                {
                    //break;
                    repeat =  false;
                }
                else
                {
                    Console.WriteLine(action + " is not a valid command");
                }

            }
            
        }      
    }   
}

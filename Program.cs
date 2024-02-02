using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VirtualPetApp
{
    class Pet
    {
        static void Main(string[] args)
        {
            //Asking user about the selection among pets. 
            Console.WriteLine("please enetr your choice for pet:");
            Console.WriteLine("Enter 1 for Cat.\n Enter 2 for Dog.\n Enter 3 for Rabbit.");
            int choice = Convert.ToInt32(Console.ReadLine());
            string Cat = "";
            String Dog = "";
            String Rabbit = "";
            Console.WriteLine("your selected choice is: " + choice);
            if (choice == 1)
            {
                Console.WriteLine("you have choosen Cat as a pet.");
            }
            else if(choice == 2)
            {
                Console.WriteLine("you have choosen Dog as a pet.");
            }
            else
            {
                Console.WriteLine("you have choosen Rabbit as a pet.");
            }

            //Asking user about name of a pet.
            Console.WriteLine("What would you like to keep as your pet Name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Welcome "+ Name + "\nLet's do some Action "+ Name);

            /*Console.WriteLine("Press 1 for feeding.\n Press 2 for Playing.\n Press 3 for Resting.");
            int Action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your chosen action is: " + Action);

            string Feed = "feed";
            string Play = "play with";
            string Rest = "give rest to";

            if (Action == 1 && choice == 1)
            {
                Console.WriteLine("you want to "+ Feed + " " + Cat);
            }
            else if (Action == 2 && choice == 1)
            {
                Console.WriteLine("you want to " + Play + " " + Cat);
            }
            else if (Action == 3 && choice == 1)
            {
                Console.WriteLine("you want to " + Rest + " " + Cat);
            }
            else if (Action == 2 && choice == 1)
            {
                Console.WriteLine("you want to " + Play + " " + Cat);
            }*/
        }
    }
}
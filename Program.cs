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
            Console.WriteLine("Enter 1 for Cat.\nEnter 2 for Dog.\nEnter 3 for Rabbit.");
            int choice = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("\n");
            Console.WriteLine("What would you like to keep as your pet Name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Welcome, "+ Name + "\nLet's do some Action "+ Name + " !!!");
            Console.WriteLine("\n");
            int exit = 0;
            int Happyness = 3;
            int Hunger = 3;
            int Health = 3;

            //Asking user for doing action 
            while(exit != 5)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please select Action you want to do with " + Name);
                Console.WriteLine("1 for feeding " + Name + "\n2 for playing with "+ Name + "\n3 for giving rest to "+ Name + "\n4 for Check status of "+ Name + "\n5 for Exit from game.");
                Console.WriteLine("\n");
                int Action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("your choosen Action is: "+Action);
                  
                if (Action == 1)
                {
                    if (Hunger >= 3 && Hunger <= 10)
                    {
                        Console.WriteLine("You fed " + Name + " That Action decrease it's hunger and improve health slightly.");
                        Hunger--;
                        Health++;
                    }
                    else if(Health >= 10)
                    {
                        Console.WriteLine(Name + "  is not want to eat,you are overfidding him.");
                    }
                }
                else if (Action == 2)
                {   
                    if (Hunger >= 9 || Health <= 1)
                    {
                        Console.WriteLine(Name + " is too hungary you need to feed him first then play with him.");
                       // Happyness++;
                       // Hunger++;
                    }
                    else if (Happyness >= 3 && Happyness <= 10)
                    {
                        Console.WriteLine("You played with " + Name + " That Action increase it's happiness and also increase hunger slightly.");
                        Happyness++;
                        Hunger++;
                        Health++;
                    }

                }
                else if (Action == 3)
                {
                    if (Health >= 3 && Health <= 10)
                    {
                        Console.WriteLine("You gave rest to " + Name + " That Action increase it's health but slightly decrease happiness.");
                        Health++;
                        Happyness--;
                    }
                }
                else if (Action == 4)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("The status of " + Name + " is:\n" + "Happyness level is: " + Happyness + "\nHunger level is: " + Hunger + "\nHealth level is: " + Health); 
                }
                else
                {
                    Console.WriteLine("Thank you for playing game , Good Bye!");
                    break;
                }
            }
        }
    }
}
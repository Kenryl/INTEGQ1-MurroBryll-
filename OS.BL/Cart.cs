using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace OS.BL
{
    
    public class Cart
    {
        public static void CartFunction()
        {

           
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine(" A = Check out ");
            Console.WriteLine(" B = Cancel Order ");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("\n");

            Console.WriteLine("Enter: ");


            char option = Convert.ToChar(Console.ReadLine());
            option = char.ToUpper(option);

            switch (option)
            {
                case 'A':
                    Console.WriteLine("Thanks for ordering!");
                    break;
                case 'B':
                    Console.WriteLine("Done!");
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

             

        }

    }
}

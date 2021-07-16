using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using OS.BL;

namespace OS.UI
{
    public class Home
    {

        public static void HomeFunction()
        {

            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine(" A = Shop ");
            Console.WriteLine(" B = MyAccount ");
            Console.WriteLine(" C = Cart  ");
            Console.WriteLine(" D = EXIT ");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("\n");

            Console.WriteLine("Enter: ");

            char option = Convert.ToChar(Console.ReadLine());
            option = char.ToUpper(option);

            switch (option)
            {
                case 'A':
                    Shop.Main();
                    break;


                case 'B':
                    MyAccount.Info();
                    break;

                case 'C':
                    Cart.CartFunction();
                    break;

                case 'D':
                    OS.UI.EXIT.logOut();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }



    }


    class EXIT
    {
        public static void logOut()
        {
            Console.WriteLine("---------------------------Logging out------------------------------");
            Environment.Exit(0);
        }
    }
}

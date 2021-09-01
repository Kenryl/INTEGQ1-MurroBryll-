using System;
using System.Collections.Generic;
using System.Text;

namespace OS.UI
{
    class Login
    {
        public static void Main()
        {
            Console.WriteLine("Welcome!");

            Console.Write("Username: ");
            string UName = Console.ReadLine();
            Console.Write("Password: ");
            string PWord = Console.ReadLine();

            if (UName == "admin" & PWord == "admin")
            {

                Home.HomeFunction();

            }
            else
            {
                Console.WriteLine("Please try again.....");
            }
        }
    }
}

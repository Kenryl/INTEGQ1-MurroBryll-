using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;







namespace OS.BL
{
    public class Shop
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("-----------------Shop-----------------");
            Console.WriteLine("Please wait");
            Thread.Sleep(1000);

            Console.WriteLine("Input Order :");
            string Order = Console.ReadLine();
            Console.WriteLine("\n");


            Console.WriteLine("---------------Added to cart---------------");

            Thread.Sleep(3000);

            Cart.CartFunction();

        }

       





    }
        
   
}
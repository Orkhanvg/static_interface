using System;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class=new Class1();
            
            
            Console.Write("Please enter the ID:             ");
            class.d = Console.ReadLine();

            Console.Write("Please enter the Fullname:             ");
            string Fullname = Console.ReadLine();

            Console.Write("Please enter the Email:             ");
            string Email = Console.ReadLine();

            Console.Write("Please enter the Password:             ");
            string Password = Console.ReadLine();


           
            

        }
    }
}

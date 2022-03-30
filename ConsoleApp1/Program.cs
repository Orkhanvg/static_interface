using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            do
            {
                Console.Write("Please enter the Fullname:             ");
                string fullname = Console.ReadLine();

                Console.Write("Please enter the Email:             ");
                string email = Console.ReadLine();

                Console.Write("Please enter the Password:             ");
                string password = Console.ReadLine();

                Class1 user = new Class1(email, password);
                user.Fullname = fullname;

                user.ShowInfo();
            } while (Console.ReadKey().Key != ConsoleKey.Enter);


        }


    }
}


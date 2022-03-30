using System;

namespace ConsoleApp1.Models
{
    class Student:Class1
    {
        public int Point;
        public int point { get; set; }

        public Student(int point)
        {
            Point = point;

        }

        public void Studentinfo()
        {
            Console.WriteLine($"_id: {ID}\n" +
               $"Fullname: {Fullname}\n" +
               $"Point: {Point}");
        }

        






    }
}

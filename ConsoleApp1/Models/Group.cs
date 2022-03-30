using System;

namespace ConsoleApp1.Models
{
    class Group
    {
        public string Groupno;
        private int _studentLimit;

        public int GetStudentLimit()
        { return _studentLimit; }
        public void SetStudentLimit(int value)
        {
            if (value > 4 && value < 19)
            {
                _studentLimit = value;


            }
            else
            {
                Console.WriteLine("Out of limit:     ");

            }



        }

        private Student[] arr = new Student[0];

        public bool CheckGroupNo(string GroupNo)
        {

            bool result = false;
            bool result1 = char.IsUpper(GroupNo[0]);
            bool result2 = char.IsUpper(GroupNo[1]);




            for (int i = 0; i < GroupNo.Length; i++)
            {

                int a = 0;
                char.IsNumber(GroupNo[i]);
                if 
                {

                }








            }
        }


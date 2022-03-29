using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Class1:IAccount
    {
        public int ID
        {
            get
            {
                { return ID; }


            }
            set
            {
                { ID = value; }

            }
        }


        public string Fullname
        {
            get
            {
                { return Fullname; }


            }
            set
            {
                { Fullname = value; }

            }



        }
        public string Email
        
        {
            get
            {
                { return Email; }


            }
            set
            {
                { Email = value; }

            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }




            set
            {
                if (String.IsNullOrEmpty(value) == false && value.Length >= 8 == true && PasswordChecker(value) == true)
                {
                    _password = value;
                    return;

                }
                Console.WriteLine("Password invalid try again:     ");
                return;


            }

        }
        

        public  void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}"+/n);
            Console.WriteLine($"fullname: {Fullname}");
            Console.WriteLine($"Email: {Email}");
        }

        public bool PasswordChecker(string password)
        {
           
            bool result = false;
            bool result1 = false;
            bool result2 = false;

            for (int i = 0; i < password.Length; i++)
            {


                if (result1 != char.IsUpper(password[i]))
                {
                    result = true;
                }

                if (result2 != char.IsNumber(password[i]))
                {
                    result = true;
                }

                if (result1 == true && result2 == true)
                {
                    result = true;
                }
                return result;
            }
            return result;
        }
    }
}

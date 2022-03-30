using System;

namespace ConsoleApp1.Models
{
    class Class1 : IAccount
    {
        private static int _id;
        public int ID
        {
            get;


        }


        public string Fullname { get; set; }
        public string Email { get; set; }
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
        public Class1(string email, string password)
        {
            Email = email;
            Password = password;
            _id++;
            ID = _id;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID }\n" +
                $"fullname: {Fullname}\n" +
                $"Email: {Email}");

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
    interface IAccount
    {
        public bool PasswordChecker(string password);

        public void ShowInfo();

    }

   


}

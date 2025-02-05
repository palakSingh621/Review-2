using System;
namespace Review_2
{
    internal class Student
    {
        private readonly int ID;
        private string name;
        private string email;
        private string password;

        public Student(string name, string email, string password)
        {
            Random random = new Random();
            this.ID= random.Next();
            this.name = name;
            this.email = email;
            this.password = password;
        }
        public void UserRegistration()
        {
            Console.WriteLine("Your Reagistration is done successfully!!");
        }
        public bool UserLogin(string input_name, string input_password , Student student)
        {
            if(input_name== student.name && input_password== student.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateUserLogin(string name, string email, string password, Student student)
        {
                student.name = name;
                student.email = email;
                student.password = password;
        }
    }
    class CheckStudent
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("palak", "palak@gmail.com", "tyuf");
            while(true)
            {
                Console.WriteLine("Service List: ");
                Console.WriteLine("1. User Registration");
                Console.WriteLine("2. User Login");
                Console.WriteLine("3. Upadate User Login");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Enter your Service Choice: ");
                string choice= Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        student1.UserRegistration();
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Enter Your Name: ");
                        string user_Name = Console.ReadLine();
                        Console.WriteLine("Create and enter a Password:");
                        string user_password = Console.ReadLine();
                        if(student1.UserLogin(user_Name, user_password,student1))
                        { 
                            Console.WriteLine("Credentaials Validated, User Login successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid User Credentials");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter Your Name: ");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Create and enter a Password:");
                        string Password = Console.ReadLine();
                        if(student1.UserLogin(Name, Password, student1))
                        {
                            Console.WriteLine("Enter the new Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Create and enter the new Password:");
                            string password = Console.ReadLine();
                            Console.WriteLine("Enter the new Email: ");
                            string email=Console.ReadLine();
                            student1.UpdateUserLogin(name, email, password, student1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User Credentials");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Have a Good Day!!");
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}

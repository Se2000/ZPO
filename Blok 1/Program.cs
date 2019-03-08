using System;

namespace Blok_1
{
    namespace Finances

    {
        class Person
        {
            private string Name;

            public string name
            {
                get
                {
                    return Name;
                }
            }

            private string Surname;

            public string surname
            {
                get
                {
                    return Surname;
                }
            }

            public Person(string name, string surname)
            {
                Name = name;
                Surname = surname;
            }

            public string GetName()
            {
                return Name;
            }

            public void SetName(string Name)
            {
                this.Name = Name;
            }

            public string GetSurname()
            {
                return Surname;
            }

            public void SetSurname(string Surname)
            {
                this.Surname = Surname;
            }
        }

        class Employee : Person
        {
            private string Position_in_company;

            public string position_in_company
            {
                get
                {
                    return Position_in_company;
                }
            }

            static decimal HolidayBonus = 1000;


            public Employee(string name, string surname, string position_in_company) :
                base(name, surname)
            {
                Position_in_company = position_in_company;
            }

            private Wage Wage;
            public Wage wage
            {
                get { return Wage; }
                set
                {
                    if (LoginVerification.Logging() == true)
                    {
                        Wage = value;
                        Console.WriteLine("Value accepted.");
                    }
                    else Console.WriteLine("Not logged in.");
                }
            }

            public enum ContractTypes { FullTime, PartTime, Contract };
            public ContractTypes Contract { get; set; }
        }

        class Client : Person
        {
            public string Order;

            public Client(string name, string surname, string order) : base(name, surname)
            {
                Order = order;
            }
        }

        class Manager : Employee
        {
            public int How_many_employes;

            public Manager(string name, string surname, string position_in_company, int how_many_employes) : base(name, surname, position_in_company)
            {
                How_many_employes = how_many_employes;
            }
        }

        public struct Wage
        {
            public decimal Base_salary { get; set; }
            public decimal Bonus_pay { get; set; }
            public decimal Other_payments { get; set; }

            public Wage(decimal base_salary, decimal bonus_pay, decimal other_payments)
            {
                Base_salary = base_salary;
                Bonus_pay = bonus_pay;
                Other_payments = other_payments;
            }

            public decimal Net_salary()
            {
                return Base_salary + Bonus_pay + Other_payments;
            }
        }

        class LoginVerification
        {
            public static bool IsLoggedIn { private set; get; }

            public static bool Logging()
            {
                string Login, Password;

                Console.WriteLine("Enter Login: ");
                Login = Console.ReadLine();

                Console.WriteLine("Enter Password: ");
                Password = Console.ReadLine();

                if (Login == "boss" && Password =="1234")
                {
                    IsLoggedIn = true;
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        class Operation
        {
            public string Name_of_operation { get; set; }
            public string Type_of_operation { get; set; }
            public decimal Amount { get; set; }

            public Operation(string name_of_operation, string type_of_operation, decimal amount)
            {
                Name_of_operation = name_of_operation;
                Type_of_operation = type_of_operation;
                Amount = amount;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(LoginVerification.IsLoggedIn);
                LoginVerification.Logging();
                Console.WriteLine(LoginVerification.IsLoggedIn);

            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Bank_system
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            
            Console.WriteLine("Hello from the ATM machine");
            Console.WriteLine("Sign up to continue");
            Console.WriteLine("contact name");
            var name = Console.ReadLine();
            Console.WriteLine("Contact account number");
            var Accnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Password");
            var pass = Convert.ToInt32(Console.ReadLine());
            
            var userss = new User();
            var newAccount = new Account()
            {
                Name = name,
                AccNumber = Accnum,
                Password = pass,
                balance = 5000
            };
            accounts.Add(newAccount);     
            
            Console.WriteLine("input your password to continue");
            var userInputs = Convert.ToInt32(Console.ReadLine());
            
            
            if (userInputs == pass)
            {
                Console.WriteLine("Hello from the ATM machine");
                Console.WriteLine("Select an operation");
                Console.WriteLine("1 check Balance");
                Console.WriteLine("2 withdraw cash");
                Console.WriteLine("3 change password");
                var userInput = Console.ReadLine();
                Balance code = new Balance();

                while (true)
                {
                    switch (userInput)
                    {
                        case "1":
                            
                            Console.WriteLine(newAccount.balance);
                            break;
                        case "2":

                            Console.WriteLine("Enter amount to be withdrawn");
                            var cash = Convert.ToInt32(Console.ReadLine());
                            var bal = newAccount.balance - cash;
                            Console.WriteLine(bal);
                            System.Threading.Thread.Sleep(1500);
                            newAccount.balance = bal;
                            Console.WriteLine("your new balance is" + newAccount.balance) ;

                            break;
                        case "x":
                            return;
                        default:
                            Console.WriteLine("select valid operation");
                            break;
                    }
                    Console.WriteLine("select operation");
                    userInput = Console.ReadLine();
                }
            }else
            {
                Console.WriteLine("sign up");
            }

            
        }
    }
}

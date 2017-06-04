using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome***");

            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Browse & Shop");
            Console.WriteLine("3. Payment");
            Console.WriteLine("4. Return an Item");
            Console.Write("Please select an option from above");
            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    Console.WriteLine("Thank you!");
                    return;

                case "1":
                    Console.Write("Name :");
                    var name = Console.ReadLine();
                    Console.Write("Email Address :");
                    var emailadd = Console.ReadLine();
                    Console.Write("Address :");
                    var addr = Console.ReadLine();

                    var user = Inter.CreateAccount(name,emailadd, addr);
                    Console.WriteLine($"AccountNumber: {user.AccountNumber}, Name: {user.Name}, Email Address: {user.EmailAddress}, Address: {user.Address}");
                    break;

                case "2":
                    
                    break;

                case "3":
                    Console.Write("Choose a Payment Method: ");
                    var paymentTypes = Enum.GetNames(typeof(PaymentTypes));
                    for(int i=0; i < paymentTypes.Length; i ++)
                    {
                        Console.WriteLine($"{ i + 1}. {paymentTypes[i]}");
                    }
                    var typeOfPay = (PaymentTypes)(Convert.ToInt32(Console.ReadLine()) - 1);


                    Console.Write("Card Number :");
                    var cardnum = Console.ReadLine();
                    Console.Write("Card Name :");
                    var cardname = Console.ReadLine();
                    Console.Write("CCV :");
                    var ccv = Console.ReadLine();
                    Console.Write("Exp Date : ");
                    var exp = Console.ReadLine();
                    Console.Write("Address to be mailed : ");
                    var address = Console.ReadLine();
                    break;

                case "4":
                    break;

                default:
                    break;
            }

        }
    }
}

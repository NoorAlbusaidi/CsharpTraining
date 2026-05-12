using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankingSystem

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            int module;
            int option;
            int accountNumber = 0;
            string holderName;
            double balance;
            bool isActive = false;
            char accountType;
            bool isEmployed = false;
            double salary;
            int creditScore;
            int age;
            double deposit;
            double withdrawal;
            double annualRate;
            double avgBalance;

            //Task 1 · System Setup — Run This First
            //options 1-13
            Console.WriteLine("=== SYSTEM SETUP — Enter Account & Customer Data ===");
            Console.WriteLine("--- Account Profile ---");
            Console.WriteLine("1) Account Number");
            Console.WriteLine("2) Holder Name");
            Console.WriteLine("3) Balance");
            Console.WriteLine("4) Account Active?");
            Console.WriteLine("5) Account Type");
            Console.WriteLine();
            Console.WriteLine("--- Customer Profile ---");
            Console.WriteLine("6) Employed?");
            Console.WriteLine("7) Monthly Salary");
            Console.WriteLine("8) Credit Score");
            Console.WriteLine("9) Age");
            Console.WriteLine();
            Console.WriteLine("--- Transaction Data ---");
            Console.WriteLine("10) Last Deposit Amount");
            Console.WriteLine("11) Last Withdrawal");
            Console.WriteLine("12) Annual Interest Rate");
            Console.WriteLine("13) Avg Monthly Balance");
            Console.WriteLine("0) Setup complete — launch Main Menu");

            Console.Write("select option: ");
            option = int.Parse(Console.ReadLine());


            while (option != 0) {

                switch (option)
                {
                    case 1:

                        Console.Write("enter your account number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("your account number set to: " + accountNumber);
                        break;

                    case 2:
                        Console.Write("enter Holder Name: ");
                        holderName = Console.ReadLine();
                        Console.WriteLine("Holder Name set to: " + holderName);
                        break;

                    case 3:
                        Console.Write("enter the balance: ");
                        balance = int.Parse(Console.ReadLine());
                        Console.WriteLine("Balance set to: " + balance);
                        break;

                    case 4:
                        Console.Write("Is your Account Active [enter 1=yes / 0=no]: ");
                        int activeState = int.Parse(Console.ReadLine());
                        if (activeState == 0)
                        {
                            isActive = false;
                            Console.WriteLine("The account is inactive");
                        }
                        else if (activeState == 1)
                        {
                            isActive = true;
                            Console.WriteLine("The account is active");
                        }
                        break;

                    case 5:
                        Console.Write("Account Type [enter S / C / F]: ");
                        accountType = char.Parse(Console.ReadLine());
                        accountType = char.ToUpper(accountType);
                        Console.WriteLine("Account Type set to: " + accountType);
                        break;

                    case 6:
                        Console.Write("Are you employed? [enter 1=yes / 0=no]: ");
                        int employState = int.Parse(Console.ReadLine());
                        if (employState == 0)
                        {
                            isEmployed = false;
                            Console.WriteLine("Employed");
                        }
                        else if (employState == 1)
                        {
                            isEmployed = true;
                            Console.WriteLine("Unemployed");
                        }
                        break;

                    case 7:
                        Console.Write("Enter Monthly Salary: ");
                        salary = Math.Round(double.Parse(Console.ReadLine()),3);
                        Console.WriteLine("The Monthly Salary set to: " + salary);
                        break;

                    case 8:
                        Console.Write("Enter Credit Score: ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine("The credit Score set to: " + creditScore);
                        break;

                    case 9:
                        Console.Write("Enter customer age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("The age set to: " + age);
                        break;

                    case 10:
                        Console.Write("enter last deposit amount: ");
                        deposit = Math.Round(double.Parse(Console.ReadLine()),3);
                        Console.WriteLine("The last deposit amount set to: " + deposit);
                        break;

                    case 11:
                        Console.Write("enter last enter last withdrawal amount: ");
                        withdrawal = Math.Round(double.Parse(Console.ReadLine()), 3);
                        Console.WriteLine("The last withdrawal amount set to: " + withdrawal);
                        break;

                    case 12:
                        Console.Write("Enter the annual interest rate: ");
                        annualRate = Math.Round(double.Parse(Console.ReadLine()), 3);
                        Console.WriteLine("The annual interest rate set to: " + annualRate);
                        break;

                    case 13:
                        Console.Write("Enter avg monthly balance: ");
                        avgBalance = Math.Round(double.Parse(Console.ReadLine()), 3);
                        Console.WriteLine("The avg monthly balance set to: " + avgBalance);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1–13 or 0 to finish.");
                        break;
                

                }
                Console.Write("select option: ");
                option = int.Parse(Console.ReadLine());

            }

























            /*
            //main menue of the bank system
            Console.WriteLine("NATIONAL BANK OF OMAN — Unified Banking System");
            Console.WriteLine("MAIN MENU: ");
            Console.WriteLine("1) ATM Services");
            Console.WriteLine("2) Account Management");
            Console.WriteLine("3) Loan Services");
            Console.WriteLine("4) Currency Exchange");
            Console.WriteLine("5) Credit Card Portal");
            Console.WriteLine("6) Branch Services");
            Console.WriteLine("7) Reports & Admin");
            Console.WriteLine("8) Full Terminal");
            Console.WriteLine("0) Exit");

            // request the module namber from customer
            Console.Write("Select module: ");
            module = int.Parse(Console.ReadLine());
            */
        }
    }
}

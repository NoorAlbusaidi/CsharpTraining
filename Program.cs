using System.Net.NetworkInformation;
using System.Numerics;
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
            string holderName = "";
            double balance = 0.000;
            bool isActive = false;
            char accountType = '-';
            bool isEmployed = false;
            double salary;
            int creditScore = 0;
            int age = -1;
            double deposit = 0.000;
            double withdrawal = 0.000;
            double annualRate =  0.000;
            double avgBalance =  0.000;
            int choice = -1;
            int Backchoice2 = -1;

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
                        Console.WriteLine("Balance set to: " + balance.ToString("F3") + " OMR");
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
                        Console.WriteLine("The Monthly Salary set to: " + salary.ToString("F3") + " OMR");
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
                        Console.WriteLine("The last deposit amount set to: " + deposit.ToString("F3")+" OMR");
                        break;

                    case 11:
                        Console.Write("enter last enter last withdrawal amount: ");
                        withdrawal = Math.Round(double.Parse(Console.ReadLine()), 3);
                        Console.WriteLine("The last withdrawal amount set to: " + withdrawal.ToString("F3") + " OMR");
                        break;

                    case 12:
                        Console.Write("Enter the annual interest rate: ");
                        annualRate = Math.Round(double.Parse(Console.ReadLine()), 3);
                        Console.WriteLine("The annual interest rate set to: " + annualRate.ToString("F3") + " OMR");
                        break;

                    case 13:
                        Console.Write("Enter avg monthly balance: ");
                        avgBalance = Math.Round(double.Parse(Console.ReadLine()), 3);
                        Console.WriteLine("The avg monthly balance set to: " + avgBalance.ToString("F3") + " OMR");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1–13 or 0 to finish.");
                        break;
                

                }
                Console.Write("select option: ");
                option = int.Parse(Console.ReadLine());

            }
            // to duple check it is zero(user entered zero)
            if (option == 0) {
                Console.WriteLine("Setup complete. Launching Main Menu...");
               
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

                // request the module number from customer
                Console.Write("Select module of main service: ");
                module = int.Parse(Console.ReadLine());
                while (module != 0) {

                    switch (module)
                    {
                        // atm services
                        case 1:

                            Console.WriteLine("=== ATM Services ===");
                            Console.WriteLine("1- general info");
                            Console.WriteLine("2- view account data");
                            Console.WriteLine("3- PIN validation");
                            Console.WriteLine("4- Receipt printer");
                            Console.Write("Selected ATM service: ");
                            int ATMserviceChoice = int.Parse(Console.ReadLine());
                            switch (ATMserviceChoice)
                            {
                                case 1:
                                    Console.WriteLine("=== General info ===");
                                    Console.WriteLine("1) Bank Info");
                                    Console.WriteLine("2) Branch Info");
                                    Console.WriteLine("3) Opening Hours");
                                    Console.WriteLine("0) Back to Main Menu");
                                    Console.Write("Select: ");
                                    choice = int.Parse(Console.ReadLine());

                                    switch (choice)
                                    {

                                        case 1:
                                            Console.WriteLine("Bank Name: National Bank of Oman");
                                            Console.WriteLine("Tagline: Trusted banking for a stronger tomorrow.");
                                            Console.WriteLine("Founding Year: 1973");
                                            break;

                                        case 2:
                                            Console.WriteLine("Branch Name: Ruwi Main Branch");
                                            Console.WriteLine("City:Muscat ");
                                            Console.WriteLine("Address: Ruwi High Street, Near Commercial Area, Muscat, Oman");
                                            break;

                                        case 3:
                                            Console.WriteLine("Weekdays (Sunday – Thursday) \n 8:00 AM – 2:00 PM ");
                                            Console.WriteLine("Weekend (Friday & Saturday): Closed");
                                            break;

                                        case 0:
                                            Console.WriteLine("Returning to Main Menu...");

                                            break;

                                        default:
                                            Console.WriteLine("Invalid selection. Please try again.");
                                            break;

                                    }//inner switch
                                    break;

                                case 2:
                                    Console.WriteLine("=== view account data ===");
                                    Console.WriteLine("1) Account Number");
                                    Console.WriteLine("2) Holder Name");
                                    Console.WriteLine("3) Balance");
                                    Console.WriteLine("4) Status");
                                    Console.WriteLine("5) Account Type");
                                    Console.WriteLine("0) Back to main menue");
                                    Console.Write("Select field: ");
                                    choice = int.Parse(Console.ReadLine());
                                    switch (choice)
                                    {
                                        case 1:
                                            Console.WriteLine("Account Number ---> " + accountNumber);
                                            break;

                                        case 2:
                                            Console.WriteLine("Holder Name ---> " + holderName);
                                            break;

                                        case 3:
                                            Console.WriteLine("Balance ---> " + balance + " OMR");
                                            break;

                                        case 4:
                                            if (isActive)
                                                Console.WriteLine(" acount Status ---> active");
                                            else
                                                Console.WriteLine(" acount Status ---> inactive");
                                            break;

                                        case 5:
                                            Console.WriteLine("Account Type ---> " + accountType);
                                            break;

                                        case 0:
                                            break;

                                        default:
                                            Console.WriteLine("Field not available.");
                                            break;
                                    }//inner switch
                                    break;

                                case 3:
                                    const string CORRECT_PIN = "4821";
                                    const int MAX_ATTEMPTS = 3;
                                    Console.WriteLine("=== Authentication ===");
                                    Console.WriteLine("1)  Enter PIN");
                                    Console.WriteLine("2) Forgot PIN");
                                    Console.WriteLine("0) Back to main menue");
                                    Console.Write("Select: ");
                                    choice = int.Parse(Console.ReadLine());

                                    switch (choice)
                                    {
                                        case 1:

                                            Console.Write("Enter your PIN: ");
                                            string pinInput = "";

                                            //ConsoleKeyInfo (get information about the pressed key) = object that contains details about the key.
                                            ConsoleKeyInfo key;
                                            do
                                            {
                                                //Waits for the user to press one key. true: don’t display it
                                                key = Console.ReadKey(true);
                                                //KeyChar:  letters / numbers
                                                // to not accept other than numbers and letters
                                                if (char.IsLetterOrDigit(key.KeyChar))
                                                {
                                                    pinInput += key.KeyChar;
                                                    Console.Write("*");
                                                }

                                                /*
                                                Keep repeating until the user presses Enter
                                                key.Key = The key the user pressed. key.key to detect the special char like enter
                                                Represents the Enter key
                                                */
                                            } while (key.Key != ConsoleKey.Enter);

                                            Console.WriteLine();
                                            if (pinInput == CORRECT_PIN)
                                                Console.WriteLine("Access granted. Welcome, " + holderName);
                                            else if (pinInput.Length != 4)
                                                Console.WriteLine("Invalid PIN format ");
                                            else
                                                Console.WriteLine("Incorrect PIN ");
                                            break;

                                        case 2:
                                            Console.WriteLine("Please visit the nearest branch with your National ID.");
                                            break;
                                        case 0:
                                            break;
                                    }//inner switch
                                    break;

                                case 4:
                                    Console.WriteLine("=== PRINT RECEIPT ===");
                                    Console.WriteLine("1)  Short Receipt");
                                    Console.WriteLine("2)  Detailed Receip");
                                    Console.WriteLine("3)  Balance Only");
                                    Console.WriteLine("0) Back to main menue");
                                    Console.Write("Select format: ");
                                    choice = int.Parse(Console.ReadLine());
                                    switch (choice)
                                    {
                                        case 1:
                                            Console.WriteLine(" holder Name: " + holderName);
                                            string receiptAccountNumber = accountNumber.ToString();
                                            string last4 = receiptAccountNumber.Substring(receiptAccountNumber.Length - 4);
                                            string stars = "";
                                            for (int i = 0; i < (receiptAccountNumber.Length - 4); i++)
                                            {
                                                stars += "*";
                                            }
                                            string starsLast4 = stars + last4;
                                            Console.WriteLine(" The account number: " + starsLast4);
                                            Console.WriteLine(" The Balance: " + balance.ToString("F3") + " OMR ");
                                            break;

                                        case 2:
                                            Console.WriteLine(" holder Name: " + holderName);
                                            receiptAccountNumber = accountNumber.ToString();
                                            last4 = receiptAccountNumber.Substring(receiptAccountNumber.Length - 4);
                                            stars = "";
                                            for (int i = 0; i < (receiptAccountNumber.Length - 4); i++)
                                            {
                                                stars += "*";
                                            }
                                            starsLast4 = stars + last4;
                                            Console.WriteLine(" The account number: " + starsLast4);
                                            Console.WriteLine(" The Balance: " + balance.ToString("F3") + " OMR ");
                                            Console.WriteLine("Account Type set to: " + accountType);
                                            Console.WriteLine("The age set to: " + age);
                                            Console.WriteLine("The credit Score set to: " + creditScore);
                                            Console.WriteLine("The avg monthly balance set to: " + avgBalance.ToString("F3") + " OMR");
                                            Console.WriteLine("The annual interest rate set to: " + annualRate.ToString("F3") + " OMR");
                                            Console.WriteLine("The last withdrawal amount set to: " + withdrawal.ToString("F3") + " OMR");
                                            Console.WriteLine("The last deposit amount set to: " + deposit.ToString("F3") + " OMR");
                                            if (isEmployed)
                                                Console.WriteLine("Employed");
                                            else
                                                Console.WriteLine("Unemployed");
                                            break;

                                        case 3:
                                            Console.WriteLine(" The Balance: " + balance.ToString("F3") + " OMR ");
                                            break;



                                    }
                                    break;
                                default:
                                    break;
                            }//ATM services
                            // choice is the common variable and 0 means go back to main menue in all cases 
                            if (choice == 0)
                            {
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
                                Console.Write("Select module of main service: ");
                                module = int.Parse(Console.ReadLine());
                            }
                            // to avoid infinit loop cause will stack in the same module number
                            else break;
                        break; //break of case 1 (module 1)
                        case 2: // account management
                            Console.WriteLine("=== Account management Services ===");
                            Console.WriteLine("1- Transaction calculator");
                            Console.WriteLine("2- Account Types");
                            Console.WriteLine("3- Loan eligability");
                            Console.Write("Selected Account management service: ");
                            int AMSChoice = int.Parse(Console.ReadLine());
                            switch(AMSChoice)
                            {
                                // Transaction calculator
                                case 1:
                                    Console.WriteLine("=== Transaction calculator ===");
                                    Console.WriteLine(" 1) After Deposit");
                                    Console.WriteLine(" 2) After Withdrawal");
                                    Console.WriteLine(" 3) Annual Interest");
                                    Console.WriteLine(" 4) Net Change");
                                    Console.WriteLine(" 0) Back");
                                    Console.Write("Select calculation: ");
                                    Backchoice2 = int.Parse(Console.ReadLine());
                                    switch (Backchoice2) {
                                        case 1:
                                            balance = balance + deposit;
                                            Console.WriteLine("Balance after deposite is: " + balance);
                                            break;
                                        case 2:
                                            if (withdrawal <= balance)
                                            {
                                                balance = balance - withdrawal;
                                                Console.WriteLine("Balance after deposite is: " + balance);
                                            }
                                            else Console.WriteLine("cannot be done your Balance less than the withdrawal amount");
                                            break;
                                        case 3:
                                            
                                            double interest = balance * annualRate;
                                            Console.WriteLine("the rate applied: "+ annualRate);
                                            Console.WriteLine("the interest: " + interest);
                                            break;
                                        case 4:
                                            double net = deposit - withdrawal;
                                            if (net >= 0)
                                                Console.WriteLine("Surplus");
                                            else Console.WriteLine("Deficit");
                                            break;

                                        case 0:
                                            break; //later on will handle the return back case

                                        default:
                                            Console.WriteLine("Calculation not available");
                                            break;
                                            //break;
                                    }// inner switch Transaction calculator
                                    break;
                                //Account Types
                                case 2:
                                    Console.WriteLine("=== Account Types ===");
                                    if (accountType == 'S')
                                    {
                                        Console.WriteLine(" Your account type: " + accountType + " (Savings Account) ");

                                    }
                                    else if (accountType == 'C') {

                                        Console.WriteLine(" Your account type: " + accountType + " (Current Account) ");

                                    }
                                    else if (accountType == 'F')
                                    {

                                        Console.WriteLine(" Your account type: " + accountType + " (Fixed Deposit Account) ");

                                    }
                                    else if (accountType == 'J')
                                    {

                                        Console.WriteLine(" Your account type: " + accountType + " (Junior Account) ");

                                    }

                                    Console.WriteLine(" 1) Savings");
                                    Console.WriteLine(" 2) Current");
                                    Console.WriteLine(" 3) Fixed Deposit");
                                    Console.WriteLine(" 4) Junior");
                                    Console.WriteLine(" 0) Back");
                                    Console.Write("Select type: ");
                                    Backchoice2 = int.Parse(Console.ReadLine());
                                    switch (Backchoice2) {
                                        
                                        case 1:
                                            if (accountType == 'S') {
                                                Console.WriteLine(" Savings Account");
                                                Console.WriteLine(" Minimum balance: 100 OMR");
                                                Console.WriteLine(" Monthly fee: 100 OMR");
                                            }
                                            break;
                                        case 2:
                                            if (accountType == 'C')
                                            {
                                                Console.WriteLine("Current Account");
                                                Console.WriteLine(" Minimum balance: 500 OMR");
                                                Console.WriteLine(" Monthly fee: 3 OMR");
                                            }
                                            break;

                                        case 3:
                                            if (accountType == 'F')
                                            {
                                                Console.WriteLine(" Fixed Deposit Account");
                                                Console.WriteLine(" Minimum balance: 1000 OMR");
                                                Console.WriteLine(" Monthly fee: 0 OMR");
                                            }
                                            break;

                                        case 4:
                                            if (accountType == 'J')
                                            {
                                                Console.WriteLine(" Junior Account");
                                                Console.WriteLine(" Minimum balance: 50 OMR");
                                                Console.WriteLine(" Monthly fee: 0 OMR");
                                            }
                                            break;

                                        default:
                                            Console.WriteLine("Account type not offered.");
                                            break;

                                    }
                                    break;
                            } // outer switch account management case 2

                            break;
                            }// outer switch of module
                    } // while module
                }  // if   
        }
    }
}

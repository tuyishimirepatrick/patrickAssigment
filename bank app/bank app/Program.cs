using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int amount;
            int initialAMOUNT = 50000;
            int BALANCE = 0;
            int choice;
            string fname;
            string sname;
            string gender;
            string currency;
            double account;
            int fee;
            Console.WriteLine("Enter your first name:");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your second name:");
            sname = Console.ReadLine();
            Console.WriteLine("Enter your Gender:");
            gender = Console.ReadLine();
            Console.WriteLine("Enter your currency type:");
            currency = Console.ReadLine();
            Console.WriteLine("Enter your account number");
            account = Convert.ToInt32(Console.ReadLine());
            
            
            Start:
            Console.WriteLine("\n \n \n");
            Console.WriteLine("for withdraw choose 1\n");
            Console.WriteLine("for deposit choose 2\n");
            
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1) 
            {
                Console.WriteLine("FIST NAME  : " + fname);
                Console.WriteLine("SECOND NAME:"  + sname);
                Console.WriteLine("GENDER     : " + gender);
                Console.WriteLine("ACCOUNT NUMBER: " + account);
                Console.WriteLine("BALANCE IS : " + initialAMOUNT + " " + currency);
                Console.WriteLine("\n ");
                Console.WriteLine("inter amount you want to withdraw");
                amount = Convert.ToInt32(Console.ReadLine());

                if (amount <= initialAMOUNT && initialAMOUNT >= 0)
                {
                    if (amount >= 0 && amount < 2000)
                    {
                        fee = 200;
                        BALANCE = initialAMOUNT - amount - fee;
                        initialAMOUNT = BALANCE;
                        Console.WriteLine("\n");
                        Console.WriteLine("FIST NAME  : " + fname);
                        Console.WriteLine("SECOND NAME: " + sname);
                        Console.WriteLine("GENDER     : " + gender);
                        Console.WriteLine("ACCOUNT NUMBER: " + account);
                        Console.WriteLine("WITHDRAW FEE    : " + fee + " " + currency);
                        Console.WriteLine("WITHDRAW     : " + amount);
                        Console.WriteLine("BALANCE IS : " + BALANCE + " " + currency);
                        Console.WriteLine("\n ");
                    }
                    else if(amount >= 2000 && amount <= 6000)
                    {
                        fee = 350;
                        BALANCE = initialAMOUNT - amount - fee;
                        initialAMOUNT = BALANCE;
                        Console.WriteLine("\n");
                        Console.WriteLine("FIST NAME  : " + fname);
                        Console.WriteLine("SECOND NAME: " + sname);
                        Console.WriteLine("GENDER     : " + gender);
                        Console.WriteLine("ACCOUNT NUMBER: " + account);
                        Console.WriteLine("WITHDRAW FEE    : " + fee + " " + currency);
                        Console.WriteLine("WITHDRAW     : " + amount + " " + currency);
                        Console.WriteLine("BALANCE IS : " + BALANCE + " " + currency);
                        Console.WriteLine("\n ");
                    }
                    else
                    {
                        fee = 500;
                        BALANCE = initialAMOUNT - amount - fee;
                        initialAMOUNT = BALANCE;
                        Console.WriteLine("\n");
                        Console.WriteLine("FIST NAME  : " + fname);
                        Console.WriteLine("SECOND NAME: " + sname);
                        Console.WriteLine("GENDER     : " + gender);
                        Console.WriteLine("ACCOUNT NUMBER: " + account);
                        Console.WriteLine("WITHDRAW FEE    : " + fee + " " + currency);
                        Console.WriteLine("WITHDRAW     : " + amount + " " + currency);
                        Console.WriteLine("BALANCE IS : " + BALANCE + " " + currency);
                        Console.WriteLine("\n"); 
                    }
                }
                else
                {
                    Console.WriteLine("insufficient fund to perform the transaction  " );
                    Console.WriteLine("\n");
                }    
                goto Start;
                
            } 
            else if (choice == 2) 
            {
                Console.WriteLine("your balance is " + initialAMOUNT);
                Console.WriteLine("inter amount you want to DEPOSIT");
                amount = Convert.ToInt32(Console.ReadLine());

                if (amount >= 0)
                {
                    BALANCE = initialAMOUNT + amount;
                    initialAMOUNT = BALANCE;
                    Console.WriteLine("\n");
                    Console.WriteLine("FIST NAME  : " + fname);
                    Console.WriteLine("SECOND NAME: " + sname);
                    Console.WriteLine("GENDER     : " + gender);
                    Console.WriteLine("ACCOUNT NUMBER: " + account);
                    Console.WriteLine("DEPOSIT     : " + amount + " " + currency);
                    Console.WriteLine("BALANCE IS : " + BALANCE + " " + currency);  
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("no money  TO BE DEPOSIT" ); 
                    Console.WriteLine("\n ");
                }    
                goto Start;
            } 
            else 
            {
                Console.WriteLine("invalid input.");
                Console.WriteLine("\n");
                goto Start;
            }



        }
    }
}


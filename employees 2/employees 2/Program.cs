using System;
using System.Threading;

namespace SALARY_MANAGMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int start_choice;
            float gs;
            float salary;
            float tax;
            float rssb;
            float ins;
            int hours;
            int hours_salary;
            start :
            Console.WriteLine("choose 1 for Monthly Employee");
            Console.WriteLine("choose 2 for Hourly Employee");
            Console.WriteLine("choose 3 for One-time Employee");
            Console.WriteLine("\n");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Gloss Salary");
                    gs = Convert.ToInt32(Console.ReadLine());
                    tax = gs * 30 / 100;
                    rssb = gs * 5 / 100;
                    ins = gs * 3 / 100;
                    salary = gs - tax - ins - rssb;
                    Console.WriteLine("\n");
                    Console.WriteLine(" Gloss Salary is : " + gs);
                    Console.WriteLine(" tax 30% is : " + tax);
                    Console.WriteLine(" Rssb is : "  + rssb);
                    Console.WriteLine(" Insurence is : " + ins);
                    Console.WriteLine(" Salary is : " + salary);
                    
                    break;
                case 2:
                    Console.WriteLine("Enter number of hours worked");
                    hours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter salary per hour");
                    hours_salary = Convert.ToInt32(Console.ReadLine());
                    rssb =(hours * (hours_salary * 5 / 100));
                    ins = (hours * (hours_salary * 3 / 100));
                    salary = (hours * hours_salary) - ins - rssb;
                    Console.WriteLine("\n");
                    Console.WriteLine(" Salary per hour is : " + hours_salary);
                    Console.WriteLine(" Rssb is : "  + rssb);
                    Console.WriteLine(" Insurence is : " + ins);
                    Console.WriteLine(" Salary is : " + salary);
                    
                    break;
                case 3:
                    Console.WriteLine("Enter Gloss Salary");
                    gs = Convert.ToInt32(Console.ReadLine());
                    tax = gs * 30 / 100;
                    salary = gs - tax;
                    Console.WriteLine("\n");
                    Console.WriteLine(" Gloss Salary is : " + gs);
                    Console.WriteLine(" tax 30% is : " + tax);
                    Console.WriteLine(" Salary is : " + salary);
                    
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
                      

            }
            Console.WriteLine("you have to start Please type 0 or any key to exit " );
            start_choice = Convert.ToInt32(Console.ReadLine());
            if (start_choice == 0)
            {
                goto start;
            }
            
            
        }
    }
}

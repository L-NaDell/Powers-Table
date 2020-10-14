using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");

            string again = "y";

            do
            {
                Console.Write("Enter an integer:");
                int number = int.Parse(Console.ReadLine());

                //only run if a positive number was entered
                if (number > 0)     
                {
                    int i = 1;

                    Console.WriteLine("Number\tSquared\tCubed");      
                    Console.WriteLine("======\t=======\t======");
                    for (i = 1; i <= number; i++)
                    {
                        //store methods as variable
                        double square = Squared(i);   
                        double cubed = Cubed(i);

                        Console.WriteLine($"{i}\t{square}\t{cubed}");     
                    }
                    Console.Write("Continue? (y/n)"); 
                    again = Console.ReadLine();
                }
                //number was not positive
                else
                    Console.WriteLine($"{number} is not valad.");   
            }
            while (again.ToLower() == "y"); 

            Console.WriteLine("Goodbye!");
        }

        //square method
        public static double Squared(int number)    
        {
            return Math.Pow(number, 2);
        }

        //cube method
        public static double Cubed(int number)      
        {
            return Math.Pow(number, 3);
        }
    }
}

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

                int i = 1;

                Console.WriteLine("");
                Console.WriteLine("Number   Squared     Cubed");
                Console.WriteLine("======   =======     ======");
                for (i = 1; i <= number; i++)
                {
                double square = Squared(i);
                double cubed = Cubed(i);

                    Console.WriteLine($"   {i}       {square}         {cubed}");
                }

                Console.Write("Continue? (y/n)");
                again = Console.ReadLine();
            }
            while (again.ToLower() == "y");

            Console.WriteLine("Goodbye!");

        }
        public static double Squared(int number)
        {
            return (

                Math.Pow(number, 2)
                    );

            
        }
        public static double Cubed(int number)
        {
            return(
                Math.Pow(number, 3));
        }
    }
}

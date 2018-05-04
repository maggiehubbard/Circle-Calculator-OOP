using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Circle_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double radNum;
            string response = "y";
            Console.WriteLine("Welcome to the Circle Tester: ");
            Console.WriteLine("===================================\n");

            while (response.ToLower() == "y")
            {
                Console.WriteLine("Enter radius: ");
                string rad = Console.ReadLine();
                bool valid = double.TryParse(rad, out radNum);
                while (!valid) //while loop to validate input was a number
                {
                    Console.WriteLine("Error: The input was not valid. ");
                    Console.WriteLine("Enter radius: ");
                    rad = Console.ReadLine();
                    valid = double.TryParse(rad, out radNum);
                }

                Circle circle1 = new Circle(radNum);//creates new instance (object) of circle class
                Circle.Counter++;

                //displays the circumference and area
                Console.WriteLine($"The radius of your cirlce is: {circle1.Radius}");
                Console.WriteLine($"The area of your cirlce is: {circle1.CalculateFormattedArea()}");
                Console.WriteLine($"The circumference of your cirlce is: {circle1.CalculateFormattedCircumference()}");
                Console.WriteLine("Would you like to continue? (y/n)");
                response = Console.ReadLine().ToLower();
            }
            //Pause
            Console.WriteLine($"You created {Circle.Counter} circle object(s)");
            Console.WriteLine("Goodbye!\nPress any key to exit . .");
            Console.ReadKey();

        }
    }
}

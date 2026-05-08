using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement: First line of the program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // --- Weight Input Section ---
            Console.WriteLine("Please enter the package weight:");
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                return;
            }

            // Weight check: Terminate if over 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // --- Dimensions Input Section ---
            // Prompt for Width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt for Height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt for Length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // --- Dimensional Constraint Check ---
            // Requirement: If dimensions total greater than 50, display error and end
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // --- Quote Calculation ---
            // Logic: (Width * Height * Length * Weight) / 100
            double product = width * height * length * weight;
            double quote = product / 100;

            // --- Final Result Display ---
            // Formatted to C2 (Currency with 2 decimal places)
            Console.WriteLine($"Your estimated total for shipping this package is: {quote:C}");
            Console.WriteLine("Thank you!");

            // Prevent console from closing immediately
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

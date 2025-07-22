using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.WriteLine("Please enter the package weight:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal weight))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt for package width
        Console.WriteLine("Please enter the package width:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal width))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Prompt for package height
        Console.WriteLine("Please enter the package height:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal height))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Prompt for package length
        Console.WriteLine("Please enter the package length:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal length))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        decimal dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the quote
        decimal quote = (width * height * length * weight) / 100;

        // Display the quote
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}

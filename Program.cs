using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Name and Location
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi {name}! Where are you from?");
            string location = Console.ReadLine();

            Console.WriteLine($"I have never been to {location}. I bet it is nice. Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            // 2. Current Date and Days Until Christmas
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today's date is: {today.ToString("M/d/yyyy")}");

            DateTime christmas = new DateTime(today.Year, 12, 25);
            if (today > christmas)
            {
                christmas = christmas.AddYears(1);
            }

            int daysUntilChristmas = (christmas - today).Days;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            // 3. Rainbow Size Calculator
            double radius, bandWidth, archLength, rainbowArea;
            string radiusString, bandWidthString;

            Console.WriteLine("Please input the inner radius of the rainbow (in feet):");
            radiusString = Console.ReadLine();
            radius = double.Parse(radiusString);

            Console.WriteLine("Please input the width of the rainbow's color bands (in feet):");
            bandWidthString = Console.ReadLine();
            bandWidth = double.Parse(bandWidthString);

            double outerRadius = radius + bandWidth;
            archLength = Math.Round(Math.PI * outerRadius, 2);
            rainbowArea = Math.Round(0.5 * Math.PI * (Math.Pow(outerRadius, 2) - Math.Pow(radius, 2)), 2);

            Console.WriteLine($"The outer arch length of the rainbow is {archLength} feet");
            Console.WriteLine($"The total area of the rainbow's colors is {rainbowArea} square feet");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

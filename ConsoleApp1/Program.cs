using System;

namespace IncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // ======= Person 1 Inputs =======
            Console.WriteLine("\nPerson 1"); // Label for Person 1

            Console.Write("Hourly Rate? "); // Ask hourly rate
            string hourlyRate1Input = Console.ReadLine(); // Read input as string
            decimal hourlyRate1 = Convert.ToDecimal(hourlyRate1Input); // Convert input to decimal

            Console.Write("Hours worked per week? "); // Ask hours per week
            string hoursPerWeek1Input = Console.ReadLine(); // Read input
            decimal hoursPerWeek1 = Convert.ToDecimal(hoursPerWeek1Input); // Convert to decimal

            // ======= Person 2 Inputs =======
            Console.WriteLine("\nPerson 2"); // Label for Person 2

            Console.Write("Hourly Rate? "); // Ask hourly rate
            string hourlyRate2Input = Console.ReadLine();
            decimal hourlyRate2 = Convert.ToDecimal(hourlyRate2Input);

            Console.Write("Hours worked per week? "); // Ask hours per week
            string hoursPerWeek2Input = Console.ReadLine();
            decimal hoursPerWeek2 = Convert.ToDecimal(hoursPerWeek2Input);

            // ======= Calculating Annual Salaries =======
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52; // Annual salary = rate * hours/week * weeks
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            // ======= Output the Results =======
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(annualSalary1); // Display salary of Person 1

            Console.WriteLine("\nAnnual salary of Person 2:");
            Console.WriteLine(annualSalary2); // Display salary of Person 2

            // Compare if Person 1 earns more
            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("\nPerson 1 makes more money than Person 2:");
            Console.WriteLine(person1MakesMore); // true or false

            // Keep console open
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}

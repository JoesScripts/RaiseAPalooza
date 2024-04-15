using System;

class RaiseAPalooza
{
    static void Main(string[] args)
    {
        // Prompt the user for the salary
        Console.Write("Enter the salary: $");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the raise percent
        Console.Write("Enter the raise percent: ");
        double raisePercent = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the raise amount
        Console.Write("Enter the raise amount: $");
        int raiseAmount = Convert.ToInt32(Console.ReadLine());

        // Call the first method to calculate salary after raise using raise percent
        CalculateSalary(salary, raisePercent);

        // Call the second method to calculate salary after raise using raise amount
        CalculateSalary(salary, raiseAmount);
    }

    // Method to calculate salary after a raise given the raise percent
    static void CalculateSalary(double salary, double raisePercent)
    {
        // Calculate the raise amount
        double raiseAmount = salary * raisePercent;
        // Calculate the total salary after the raise
        double totalSalary = salary + raiseAmount;

        // Display the initial salary, raise, and total salary after the raise
        Console.WriteLine($"Initial salary: ${salary}");
        Console.WriteLine($"Raise: ${raiseAmount} ({raisePercent * 100}%)");
        Console.WriteLine($"Total salary after raise: ${totalSalary}");
    }

    // Method to calculate salary after a raise given the raise amount
    static void CalculateSalary(double salary, int raiseAmount)
    {
        // Calculate the total salary after the raise
        double totalSalary = salary + raiseAmount;

        // Display the initial salary, raise, and total salary after the raise
        Console.WriteLine($"Initial salary: ${salary}");
        Console.WriteLine($"Raise: ${raiseAmount}");
        Console.WriteLine($"Total salary after raise: ${totalSalary}");
    }
}

class Program
{
    // Entry point of the dice rolling simulator program
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");

        // Input handling: Read and validate user input
        if (int.TryParse(Console.ReadLine(), out int numberOfRolls))
        {
            DiceRoller roller = new DiceRoller(); // Create a DiceRoller instance
            int[] sums = roller.RollDices(numberOfRolls); // Roll dice and gather results

            // Display results in a formatted histogram
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                double percentage = ((double)sums[i] * 100) / numberOfRolls;

                // Print asterisks as a visual representation of percentage
                for (int j = 0; j < Math.Round(percentage); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            // Inform the user if the input was not a valid integer
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        // End of program message
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}

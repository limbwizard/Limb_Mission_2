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
            // Roll dice and gather results
            int[] sums = RollDices(numberOfRolls);

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

    // Simulate dice rolls and return the sum frequency
    private static int[] RollDices(int numberOfRolls)
    {
        // Initialize a Random instance for dice rolling
        Random random = new Random();
        int[] sums = new int[13]; // Array to store frequency of sums (2-12)

        // Rolling dice specified number of times
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Simulate two dice rolls and increment corresponding sum
            int rollOne = random.Next(1, 7);
            int rollTwo = random.Next(1, 7);
            sums[rollOne + rollTwo]++;
        }

        // Return the array with the frequencies of each possible sum
        return sums;
    }
}

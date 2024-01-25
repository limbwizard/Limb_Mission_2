// Define a class for simulating dice rolls
public class DiceRoller
{
    // A static Random object shared by all instances of the class
    private static Random random = new Random();

    // Method to roll dice a specified number of times and track the sums
    public static int[] RollDices(int numberOfRolls)
    {
        // Array to store the count of each possible sum (2-12)
        // Indexes 0 and 1 are unused for simplicity
        int[] sums = new int[13];

        // Loop for the specified number of rolls
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Generate two random numbers between 1 and 6 (inclusive) for each dice roll
            int rollOne = random.Next(1, 7);
            int rollTwo = random.Next(1, 7);

            // Increment the count of the sum of the two dice
            sums[rollOne + rollTwo]++;
        }

        // Return the array with the sums of dice rolls
        return sums;
    }
}

class Program
{
    // Main method - entry point of the program
    static void Main(string[] args)
    {
        // Greet the user and ask for the number of dice rolls
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");

        // Read user input and try to parse it to an integer
        if (int.TryParse(Console.ReadLine(), out int numberOfRolls))
        {
            // Call the RollDices method and store the result in sums array
            int[] sums = DiceRoller.RollDices(numberOfRolls);

            // Display the simulation results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

            // Loop through possible sums (2-12)
            for (int i = 2; i <= 12; i++)
            {
                // Write the current sum
                Console.Write($"{i}: ");

                // Calculate and round the percentage of each sum
                double percentage = ((double)sums[i] * 100) / numberOfRolls;

                // Print asterisks based on the rounded percentage
                for (int j = 0; j < Math.Round(percentage); j++)
                {
                    Console.Write("*");
                }
                // Move to the next line
                Console.WriteLine();
            }
        }
        else
        {
            // Inform the user of invalid input
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        // Thank the user and end the program
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}



namespace DiceRollingSimulator
{
    public class DiceRoller
    {
        public static int[] RollDices(int numberOfRolls)
        {
            int[] sums = new int[13]; // Index 0 and 1 are unused, for simplicity.
            Random random = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int rollOne = random.Next(1, 7);
                int rollTwo = random.Next(1, 7);
                sums[rollOne + rollTwo]++;
            }

            return sums;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls = int.Parse(Console.ReadLine());

            int[] sums = DiceRoller.RollDices(numberOfRolls);

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                int percentage = (sums[i] * 100) / numberOfRolls;

                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

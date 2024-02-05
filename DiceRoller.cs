public class DiceRoller
{
    private Random random = new Random(); // Random instance for dice rolling

    // Method to simulate dice rolls and return the sum frequency
    public int[] RollDices(int numberOfRolls)
    {
        int[] sums = new int[13]; // Array to store frequency of sums (2-12)

        // Rolling dice the specified number of times
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Simulate two dice rolls and increment the corresponding sum
            int rollOne = random.Next(1, 7);
            int rollTwo = random.Next(1, 7);
            sums[rollOne + rollTwo]++;
        }

        // Return the array with the frequencies of each possible sum
        return sums;
    }
}

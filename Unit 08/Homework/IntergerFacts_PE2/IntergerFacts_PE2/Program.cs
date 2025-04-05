using System;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergerFacts_PE2
{
    class IntegerFacts
    {
        static void Main()
        {
            int[] numbers = new int[10]; // Declare an array of 10 integers
            int count = FillArray(numbers); // Call FillArray method to fill the array and get the count of valid entries

            int highest, lowest, sum;
            double average;

            // Call Statistics method to calculate statistics
            Statistics(numbers, count, out highest, out lowest, out sum, out average);

            // Display the statistics
            Console.WriteLine("The array has {0} values", count);
            Console.WriteLine("The highest value is {0}", highest);
            Console.WriteLine("The lowest value is {0}", lowest);
            Console.WriteLine("The sum of the values is {0}", sum);
            Console.WriteLine("The average is {0}", average);
        }

        public static int FillArray(int[] array)
        {
            Console.WriteLine("Enter up to 10 integers (999 to stop):");

            int count = 0; // Initialize count to keep track of the number of valid entries
            int input;
            while (count < array.Length)
            {
                string inputString = Console.ReadLine(); // Read input from the user

                if (!int.TryParse(inputString, out input)) // Check if the input is a valid integer
                {
                    Console.WriteLine("Invalid input. Please enter an integer."); // Inform the user of invalid input
                    continue; // Skip to the next iteration
                }

                if (input == 999) // Check if the sentinel value (999) is entered
                    break; // Exit the loop

                array[count] = input; // Store the valid integer in the array
                count++; // Increment the count
            }

            return count; // Return the count of valid entries
        }

        public static void Statistics(int[] array, int count, out int highest, out int lowest, out int sum, out double average)
        {
            highest = int.MinValue; // Initialize highest to the minimum possible integer value
            lowest = int.MaxValue; // Initialize lowest to the maximum possible integer value
            sum = 0; // Initialize sum to 0

            for (int i = 0; i < count; i++)
            {
                int num = array[i]; // Get the current number from the array
                sum += num; // Add the current number to the sum

                if (num > highest) // Check if the current number is greater than the current highest
                    highest = num; // Update highest

                if (num < lowest) // Check if the current number is less than the current lowest
                    lowest = num; // Update lowest
            }

            average = (double)sum / count; // Calculate the average by dividing the sum by the count
        }
    }
}

// Required namespaces
using System;
using System.Collections.ObjectModel;
using static System.Console;

namespace GreenvilleRevenue_CS7
{

    class GreenvilleRevenue
    {
        // Constants for minimum and maximum number of contestants
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;

        // The main method
        static void Main()
        {
            // Variables to hold the number of contestants for last year and this year
            int numThisYear;
            int numLastYear;

            // Get the number of contestants for last year and this year
            numLastYear = GetContestantNumber("last year");
            numThisYear = GetContestantNumber("this year");

            // Display the relationship between the number of contestants for last year and this year
            DisplayRelationship(numLastYear, numThisYear);

            // Initialize collections to hold the contestants based on their talent
            Collection<string> singers = new Collection<string>();
            Collection<string> dancers = new Collection<string>();
            Collection<string> musicians = new Collection<string>();
            Collection<string> others = new Collection<string>();

            // Get the data for this year's contestants
            GetContestantData(numThisYear, singers, dancers, musicians, others);

            // Display the lists of contestants based on their talent
            GetLists(singers, dancers, musicians, others);
        }

        // Method to get a valid number of contestants
        static int GetContestantNumber(string year)
        {
            // Variables to hold the user's input and the number of contestants
            string entryString;
            int num;

            // Prompt the user to enter the number of contestants
            Write($"Enter number of contestants {year} >> ");
            entryString = ReadLine();
            num = Convert.ToInt32(entryString);

            // Validate the number of contestants
            while (num < MIN_CONTESTANTS || num > MAX_CONTESTANTS)
            {
                WriteLine("Number must be between {0} and {1}", MIN_CONTESTANTS, MAX_CONTESTANTS);
                Write($"Enter number of contestants {year} >> ");
                entryString = ReadLine();
                num = Convert.ToInt32(entryString);
            }

            // Return the number of contestants
            return num;
        }

        // Method to display the relationship between the number of contestants for last year and this year
        static void DisplayRelationship(int numLastYear, int numThisYear)
        {
            // Display the number of contestants for last year and this year
            WriteLine($"Last year's competition had {numLastYear} contestants, and this year's has {numThisYear} contestants");

            // Calculate and display the expected revenue
            WriteLine("Revenue expected this year is ${0}", numThisYear * 25);

            // Display a message based on the comparison of the number of contestants
            if (numThisYear > numLastYear)
                WriteLine("The competition is bigger than ever!");
            else if (numThisYear < numLastYear)
                WriteLine("A tighter race this year! Come out and cast your vote!");
            else
                WriteLine("The competition is the same as last year.");
        }

        // Method to get the data for this year's contestants
        static void GetContestantData(int numThisYear, Collection<string> singers, Collection<string> dancers, Collection<string> musicians, Collection<string> others)
        {
            // Variables to hold the contestant's name and talent code
            string contestentName, userChoice;

            // Loop to get the data for each contestant
            for (int index = 0; index < numThisYear; index++)
            {
                // Prompt the user to enter the contestant's name
                Write("Enter name of contestant: ");
                contestentName = ReadLine();

                // Display the talent codes
                WriteLine("Talent codes are:");
                WriteLine("  S   Singing");
                WriteLine("  D   Dancing");
                WriteLine("  M   Musical instrument");
                WriteLine("  O   Other");

                // Prompt the user to enter the talent code
                Write("       Enter talent code >> ");
                userChoice = ReadLine().ToUpper();

                // Validate the talent code
                while (!(userChoice.Equals("S") || userChoice.Equals("D") || userChoice.Equals("M") || userChoice.Equals("O")))
                {
                    WriteLine("{0} is not a valid code", userChoice);
                    Write("Enter Code again: (S)inging, (D)ancing, (M)usical instrument, (O)ther: ");
                    userChoice = ReadLine();
                }

                // Add the contestant to the appropriate collection based on their talent
                switch (userChoice)
                {
                    case "S":
                        singers.Add(contestentName);
                        break;
                    case "D":
                        dancers.Add(contestentName);
                        break;
                    case "M":
                        musicians.Add(contestentName);
                        break;
                    case "O":
                        others.Add(contestentName);
                        break;
                    default:
                        break;
                }
            }
        }

        // Method to display the lists of contestants based on their talent
        static void GetLists(Collection<string> singers, Collection<string> dancers, Collection<string> musicians, Collection<string> others)
        {
            // Variable to hold the entered code
            string enteredCode;

            // Display the types of talent and the number of contestants for each type
            WriteLine("The types of talent are:");
            WriteLine("{0,-20} {1}", "Singing", singers.Count);
            WriteLine("{0,-20} {1}", "Dancing", dancers.Count);
            WriteLine("{0,-20} {1}", "Musical instrument", musicians.Count);
            WriteLine("{0,-20} {1}", "Other", others.Count);

            // Loop to continuously prompt the user to enter a talent code
            while (true)
            {
                // Prompt the user to enter a talent code
                Write("Enter code to display contestants (S for Singing, D for Dancing, M for Music, O for Other, Z to exit): ");
                enteredCode = ReadLine();

                // Break the loop if the sentinel value is entered
                if (enteredCode.Equals("Z"))
                    break;

                // Display the contestants with the corresponding talent
                switch (enteredCode.ToUpper())
                {
                    case "S":
                        WriteLine("Singing Contestants:");
                        OutputContestantNames(singers);
                        break;
                    case "D":
                        WriteLine("Dancing Contestants:");
                        OutputContestantNames(dancers);
                        break;
                    case "M":
                        WriteLine("Musical Instument Contestants:");
                        OutputContestantNames(musicians);
                        break;
                    case "O":
                        WriteLine("Other Contestants:");
                        OutputContestantNames(others);
                        break;
                    default:
                        WriteLine("{0} is not a valid code", enteredCode);
                        break;
                }
            }
        }

        // Method to output the names of contestants
        static void OutputContestantNames(Collection<string> names)
        {
            // Loop to print the names of the contestants
            foreach (var name in names)
            {
                WriteLine(name);
            }
        }
    }
}


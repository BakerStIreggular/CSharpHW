using System;
using static System.Console;

namespace GrevilleRevenue_CS8
{
    class GreenvilleRevenue
    {
        static void Main()
        {
            const int ENTRANCE_FEE = 25;
            const int MIN_CONTESTANTS = 0;
            const int MAX_CONTESTANTS = 30;
            int numThisYear;
            int numLastYear;
            int revenue;
            string[] names = new string[MAX_CONTESTANTS];
            char[] talents = new char[MAX_CONTESTANTS];
            char[] talentCodes = { 'S', 'D', 'M', 'O' };
            string[] talentCodesStrings = { "Singing", "Dancing", "Musical instrument", "Other" };
            int[] counts = { 0, 0, 0, 0 };

            numLastYear = GetContestantNumber("last", MIN_CONTESTANTS, MAX_CONTESTANTS);
            numThisYear = GetContestantNumber("this", MIN_CONTESTANTS, MAX_CONTESTANTS);
            revenue = numThisYear * ENTRANCE_FEE;
            WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", numLastYear, numThisYear);
            WriteLine("Revenue expected this year is {0}", revenue.ToString("C"));
            DisplayRelationship(numThisYear, numLastYear);
            GetContestantData(numThisYear, names, talents, talentCodes, talentCodesStrings, counts);
            GetLists(numThisYear, talentCodes, talentCodesStrings, names, talents, counts);
        }

        public static int GetContestantNumber(string when, int min, int max)
        {
            int num;
            string entryString;

            Write("Enter number of contestants {0} year >> ", when);
            entryString = ReadLine();
            while (!int.TryParse(entryString, out num) || num < min || num > max)
            {
                WriteLine("Invalid input. Number must be between {0} and {1}", min, max);
                Write("Enter number of contestants {0} year >> ", when);
                entryString = ReadLine();
            }
            return num;
        }

        public static void DisplayRelationship(int numThisYear, int numLastYear)
        {
            if (numThisYear > 2 * numLastYear)
                WriteLine("The competition is more than twice as big this year!");
            else if (numThisYear > numLastYear)
                WriteLine("The competition is bigger than ever!");
            else if (numThisYear < numLastYear)
                WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        public static void GetContestantData(int numThisYear, string[] names, char[] talents, char[] talentCodes, string[] talentCodesStrings, int[] counts)
        {
            int x = 0;
            bool isValid;
            char talentInput;

            while (x < numThisYear)
            {
                Write("Enter contestant name >> ");
                names[x] = ReadLine();
                WriteLine("Talent codes are:");
                for (int y = 0; y < talentCodes.Length; ++y)
                    WriteLine(" {0} {1}", talentCodes[y], talentCodesStrings[y]);

                Write("Enter talent code >> ");
                string talentEntry = ReadLine();
                while (!char.TryParse(talentEntry, out talentInput) || !Array.Exists(talentCodes, element => element == talentInput))
                {
                    WriteLine("Invalid input. Please enter a valid talent code.");
                    Write("Enter talent code >> ");
                    talentEntry = ReadLine();
                }

                talents[x] = talentInput;
                isValid = false;
                for (int z = 0; z < talentCodes.Length; ++z)
                {
                    if (talents[x] == talentCodes[z])
                    {
                        isValid = true;
                        ++counts[z];
                    }
                }
                ++x;
            }
        }

        public static void GetLists(int numThisYear, char[] talentCodes, string[] talentCodesStrings, string[] names, char[] talents, int[] counts)
        {
            int x;
            char QUIT = 'Z';
            char option;
            bool isValid;
            int pos = 0;
            bool found;

            WriteLine("\nThe types of talent are:");
            for (x = 0; x < counts.Length; ++x)
                WriteLine("{0, -20} {1, 5}", talentCodesStrings[x], counts[x]);

            Write("\nEnter a talent type or {0} to quit >> ", QUIT);
            string optionEntry = ReadLine();
            while (!char.TryParse(optionEntry, out option) || (option != QUIT && !Array.Exists(talentCodes, element => element == option)))
            {
                WriteLine("Invalid input. Please enter a valid talent type or {0} to quit.", QUIT);
                Write("\nEnter a talent type or {0} to quit >> ", QUIT);
                optionEntry = ReadLine();
            }

            while (option != QUIT)
            {
                isValid = false;
                for (int z = 0; z < talentCodes.Length; ++z)
                {
                    if (option == talentCodes[z])
                    {
                        isValid = true;
                        pos = z;
                    }
                }
                if (!isValid)
                    WriteLine("{0} is not a valid code", option);
                else
                {
                    WriteLine("\nContestants with talent {0} are:", talentCodesStrings[pos]);
                    found = false;
                    for (x = 0; x < numThisYear; ++x)
                    {
                        if (talents[x] == option)
                        {
                            WriteLine(names[x]);
                            found = true;
                        }
                    }
                    if (!found)
                        WriteLine("No contestants had talent {0}", talentCodesStrings[pos]);
                }

                Write("\nEnter a talent type or {0} to quit >> ", QUIT);
                optionEntry = ReadLine();
                while (!char.TryParse(optionEntry, out option) || (option != QUIT && !Array.Exists(talentCodes, element => element == option)))
                {
                    WriteLine("Invalid input. Please enter a valid talent type or {0} to quit.", QUIT);
                    Write("\nEnter a talent type or {0} to quit >> ", QUIT);
                    optionEntry = ReadLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    class Contestant
    {
        public static string[] talentCodes = { "S", "D", "M", "O" };
        public static string[] talentDescriptions = { "Singing", "Dancing", "Musical instrument", "Other" };
        private string name;
        private string code;
        private string description;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set
            {
                if (talentCodes.Contains(value))
                {
                    code = value;
                    description = talentDescriptions[Array.IndexOf(talentCodes, value)];
                }
                else
                {
                    code = "I";
                    description = "Invalid";
                }
            }
        }

        public string Description
        {
            get { return description; }
        }
    }

    class GreenvilleRevenue
    {
        static void Main(string[] args)
        {
            // Variable to store the number of contestants for this year
            int thisYearContestants;
            int i;

            // Loop until the user enters a valid number of contestants (between 0 and 30, inclusive)
            do
            {
                Console.Write("Enter the number of contestants: ");
                thisYearContestants = int.Parse(Console.ReadLine());
            } while (thisYearContestants < 0 || thisYearContestants > 30);

            // Display the expected revenue based on the number of contestants entered

            Console.WriteLine("Expected revenue: $" + (thisYearContestants * 25));
            Console.WriteLine();

            //Create an array of Contestant objects with size equal to the number of contestants for this year

            Contestant[] contestants = new Contestant[thisYearContestants];

            // Loop through each contestant and prompt the user for their name and talent code

            for (i = 0; i < thisYearContestants; i++)
            {
                // Create a new Contestant object for the current contestant
                contestants[i] = new Contestant();

                // Prompt the user for the contestant's name

                Console.Write("Enter the contestant's name: ");
                contestants[i].Name = Console.ReadLine();

                // Display the list of talent categories and their descriptions

                Console.WriteLine("Valid talent codes are:");
                for (int j = 0; j < Contestant.talentCodes.Length; j++)
                {
                    Console.WriteLine(Contestant.talentCodes[j] + " - " + Contestant.talentDescriptions[j]);
                }

                // Loop until the user enters a valid talent code for the current contestant

                do
                {
                    Console.Write("Enter the contestant's talent code: ");
                    contestants[i].Code = Console.ReadLine().ToUpper();
                } while (contestants[i].Code == "I");
            }

            Console.WriteLine("\nTalent categories:");
            for (i = 0; i < Contestant.talentCodes.Length; i++)
            {
                Console.WriteLine(Contestant.talentCodes[i] + " - " + Contestant.talentDescriptions[i]);
            }
            Console.WriteLine();

            string searchCode;
            bool found;

            do
            {
                Console.Write("Enter code to display contestants (S for Singing, D for Dancing, M for Music, O for Other, Z to exit):  ");
                searchCode = Console.ReadLine().ToUpper();
                found = false;
                if (searchCode != "Z")
                {
                    Console.WriteLine("\nContestants in the " + searchCode + " category:");
                    for (i = 0; i < thisYearContestants; i++)
                    {
                        if (contestants[i].Code == searchCode)
                        {
                            Console.WriteLine(contestants[i].Name);
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("No contestants found in the " + searchCode + " category.");
                    }
                }
            } while (searchCode != "Q");
        }
    }
}

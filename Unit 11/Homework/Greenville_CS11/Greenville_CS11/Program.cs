using System;
using System.Collections.Generic;
using System.Globalization;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store contestant information
            Dictionary<string, Contestant> contestants = new Dictionary<string, Contestant>();

            // Prompt the user for the number of contestants
            int numContestants;
            while (true)
            {
                try
                {
                    Console.Write("Enter the number of contestants (0-30): ");
                    numContestants = int.Parse(Console.ReadLine());
                    if (numContestants >= 0 && numContestants <= 30)
                        break;
                    else
                        Console.WriteLine("Number must be between 0 and 30");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number must be between 0 and 30");
                }
            }

            // Prompt the user for contestant information
            for (int i = 1; i <= numContestants; i++)
            {
                Console.WriteLine($"Contestant {i}:");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                string talentCode;
                while (true)
                {
                    Console.Write("Enter talent code: ");
                    talentCode = Console.ReadLine().ToUpper();
                    try
                    {

                        if (talentCode == "S" || talentCode == "D" || talentCode == "C" || talentCode == "I")
                            break;
                        else
                            Console.WriteLine($"{talentCode} is not a valid talent code. Assigned as Invalid.");
                        talentCode = "I";
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(value: $"{talentCode} is not a valid talent code. Assigned as Invalid.");
                        talentCode = "I";
                    }
                }
                Console.Write("Enter fee: ");
                double fee = double.Parse(Console.ReadLine());
                Contestant contestant = new Contestant(name, talentCode, fee);
                contestants.Add(contestant.Name, contestant);
            }

            // Prompt the user for talent codes to view lists of appropriate contestants
            while (true)
            {
                Console.Write("Enter a talent type or Z to quit >> ");
                string talentCode = Console.ReadLine().ToUpper();
                if (talentCode == "Z")
                    break;
                if (talentCode == "S" || talentCode == "D" || talentCode == "C" || talentCode == "I")
                {
                    Console.WriteLine($"Contestants with talent {talentCode} are:");
                    foreach (var contestant in contestants.Values)
                    {
                        if (contestant.TalentCode == talentCode)
                        {
                            Console.WriteLine($"{contestant.Name} {contestant.TalentCode} Fee {contestant.Fee.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{talentCode} is not a valid code");
                }
            }
        }
    }

    class Contestant
    {
        public string Name { get; set; }
        public string TalentCode { get; set; }
        public double Fee { get; set; }

        public Contestant(string name, string talentCode, double fee)
        {
            Name = name;
            TalentCode = talentCode;
            Fee = fee;
        }
    }
}
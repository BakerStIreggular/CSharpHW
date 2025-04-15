using System;
using static System.Console;

namespace Wk4Chapter9
{
    class Chapter9
    {
        static void Main()
        {
            int thisYearContestants;
            int lastYearContestants;

            
            WriteLine("Please enter the number of contestants entered in last year's competition: ");
            lastYearContestants = GetContestants();

            
            WriteLine("Please enter the number of contestants entered in this year's competition: ");
            thisYearContestants = GetContestants();

            
            DisplayContestantMessage(thisYearContestants, lastYearContestants);

           
            Contestant[] contestants = new Contestant[thisYearContestants];


            FillArrays(thisYearContestants, contestants);

         
            PromptTalentCodes(thisYearContestants, contestants);
        }

       
        static int GetContestants()
        {
            int contestants;
            string input = ReadLine();

            while (!Int32.TryParse(input, out contestants) || (contestants < 0 || contestants > 30))
            {
                WriteLine("Error. Please enter a value between 0 and 30.");
                input = ReadLine();
            }
            return contestants;
        }

      
        static void DisplayContestantMessage(int thisYearContestants, int lastYearContestants)
        {
            WriteLine("The revenue expected for this year's competition : $" + thisYearContestants * 25 + '\n');

            if (thisYearContestants > lastYearContestants * 2)
                WriteLine("The competition is more than twice as big this year!\n");
            else if (thisYearContestants > lastYearContestants)
                WriteLine("The competition is bigger than ever!\n");
            else if (thisYearContestants < lastYearContestants)
                WriteLine("A tighter race this year! Come out and cast your vote!\n");
        }

       
        static void FillArrays(int thisYearContestants, Contestant[] contestants)
        {
            int x = 0;
            string name;
            int age;
            char talent;

            while (x < thisYearContestants)
            {
              
                WriteLine("Enter Contestant Name: ");
                name = ReadLine();

             
                WriteLine("Enter Contestant Age: ");
                Int32.TryParse(ReadLine(), out age);

            
                WriteLine("Talent codes are:");
                for (int k = 0; k < Contestant.talentCodes.Length; ++k)
                    WriteLine(" {0} {1}", Contestant.talentCodes[k], Contestant.talentStrings[k]);

               
                WriteLine("Please enter contestant " + (x + 1) + "'s talent code: ");
                char.TryParse(ReadLine(), out talent);

                
                if (age <= 12)
                {
                    contestants[x] = new ChildContestant();
                }
                else if (age >= 13 && age <= 17)
                {
                    contestants[x] = new TeenContestant();
                }
                else
                {
                    contestants[x] = new AdultContestant();
                }

             
                contestants[x].Name = name;
                contestants[x].TalentCode = talent;
                ++x;
            }
        }


        static void PromptTalentCodes(int thisYearContestants, Contestant[] contestants)
        {
            char QUIT = 'Q'; 
            char input;
            bool isValid;
            bool correct;

            WriteLine("\n ********************************************************** \n");

          
            WriteLine("To see the contestants by talent, please search a valid talent code or " + QUIT + " to quit: ");
            WriteLine("\nThe types of talent are:");
            for (int x = 0; x < Contestant.talentStrings.Length; ++x)
                WriteLine("{0, -6}{1, -20}", Contestant.talentCodes[x], Contestant.talentStrings[x]);

            isValid = false;
            while (!isValid)
            {
                
                if (!char.TryParse(ReadLine(), out input))
                {
                    
                    WriteLine("\nInvalid talent code. Please enter a valid talent code or " + QUIT + " to quit: ");
                }
                else
                {
                    if (input == QUIT) 
                        isValid = true;
                    else
                    {
                        for (int x = 0; x < Contestant.talentCodes.Length; ++x)
                        {
                            if (input == Contestant.talentCodes[x]) 
                            {
                                WriteLine("Contestants for " + Contestant.talentStrings[x] + ":");
                                correct = false;

                                
                                for (int j = 0; j < thisYearContestants; j++)
                                {
                                    if (contestants[j].TalentCode == input)
                                    {
                                        WriteLine(contestants[j]);
                                        correct = true;
                                    }
                                }

                               
                                if (!correct)
                                    WriteLine("No contestants entered with talent " + input + ".");

                                isValid = false; 
                                break;
                            }
                        }

                       
                        if (!isValid)
                        {
                            WriteLine("\nInvalid talent code. Please enter a valid talent code or " + QUIT + " to quit: ");
                        }
                    }
                }
            }
        }
    }

  
    class Contestant
    {
        
        public static char[] talentCodes = { 'S', 'D', 'M', 'O' };
        public static string[] talentStrings = { "Singing", "Dancing", "Musical instrument", "Other" };

        public string Name { get; set; } 
        private char talentCode;         
        private string talent;         

        public decimal EntryFee { get; protected set; } 

    
        public char TalentCode
        {
            get { return talentCode; }
            set
            {
                int pos = talentCodes.Length;
                for (int x = 0; x < talentCodes.Length; ++x)
                    if (value == talentCodes[x])
                        pos = x;
                if (pos == talentCodes.Length)
                {
                    talentCode = 'I';
                    talent = "Invalid";
                }
                else
                {
                    talentCode = value;
                    talent = talentStrings[pos];
                }
            }
        }

        public string Talent => talent; 

     
        public override string ToString()
        {
            return $"{Name} - Talent: {Talent}, Entry Fee: ${EntryFee}";
        }
    }


    class ChildContestant : Contestant
    {
        public ChildContestant()
        {
            EntryFee = 15.00m; 
        }

        public override string ToString()
        {
            return base.ToString() + " (Child Contestant)";
        }
    }


    class TeenContestant : Contestant
    {
        public TeenContestant()
        {
            EntryFee = 20.00m; 
        }

        public override string ToString()
        {
            return base.ToString() + " (Teen Contestant)";
        }
    }

   
    class AdultContestant : Contestant
    {
        public AdultContestant()
        {
            EntryFee = 30.00m; 
        }

        public override string ToString()
        {
            return base.ToString() + " (Adult Contestant)";
        }
    }
}
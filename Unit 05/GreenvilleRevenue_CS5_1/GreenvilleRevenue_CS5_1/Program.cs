using System;
using static System.Console;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.Remoting.Services;
class GreenvilleRevenue
{
    static void Main()
    {
        String ContestantsLastYear, ContestantsThisYear;
        int NumberOfContestantsLastYear, NumberOfContestantsThisYear;
        const double EntranceFee = 25;
        Char[] TalentCode = { 'S', 'D', 'M','O' };
        


        do
        {
            WriteLine("Enter the number of contestants that entered last year >>");
            ContestantsLastYear = ReadLine();
            NumberOfContestantsLastYear = Convert.ToInt32(ContestantsLastYear);

            if (NumberOfContestantsLastYear < 0 || NumberOfContestantsLastYear > 30)
            {
                WriteLine("Invalid Entry: Please enter a number between 0 and 30");
            }
        }    while (NumberOfContestantsLastYear < 0 || NumberOfContestantsLastYear > 30);

        do {
            WriteLine("Enter the number of contestants that entered this year >>");
            ContestantsThisYear = ReadLine();
            NumberOfContestantsThisYear = Convert.ToInt32(ContestantsThisYear);

            if (NumberOfContestantsThisYear < 0 || NumberOfContestantsThisYear > 30)
            {
                WriteLine("Invalid Entry: Please enter a number between 0 and 30");

            }


        }   while (NumberOfContestantsThisYear < 0 || NumberOfContestantsThisYear > 30);

        string[] ContestantName = new string[NumberOfContestantsThisYear];
        Char[] ContestantTalent = new char [NumberOfContestantsThisYear];

        for (int i = 0; i < NumberOfContestantsThisYear; ++i)
        {
            WriteLine("Enter Contestants Name");
            ContestantName[i] = ReadLine();

            do
            {
                WriteLine("Enter Talent Code: S: Singing, D: Dancing, M: Musical Instrutment, O: Other");
                string TempTalent = ReadLine();

                if (TempTalent.Length == 1)
                    ContestantTalent[i] = TempTalent[0];

                else
                    ContestantTalent[i] = 'a';

                if (ContestantTalent[i] != 'S' && ContestantTalent[i] != 'D' && ContestantTalent[i] != 'M' && ContestantTalent[i] != 'O')
                    WriteLine("Please enter a valid talent code");

            } while (ContestantTalent[i] != 'S' &&  ContestantTalent[i] != 'D' && ContestantTalent[i] != 'M' && ContestantTalent[i] != 'O');

        }

        int S = 0;
        int D = 0;
        int M = 0;
        int O = 0;

        for (int i = 0; i < NumberOfContestantsThisYear; ++i)
        {
            if (ContestantTalent[i] == 'S')
                S++;
            if (ContestantTalent[i] == 'D')
                D++;
            if (ContestantTalent[i] == 'M')
                M++;
            if (ContestantTalent[i] == 'O')
                O++;

        }





            double Revenue = EntranceFee * NumberOfContestantsThisYear;

        WriteLine("Number of Contestansts Last Year: " + NumberOfContestantsLastYear);
        WriteLine("Number of Contestansts This Year: " + NumberOfContestantsThisYear);
        WriteLine("Estimated Revenue: $" + Revenue);

        if (NumberOfContestantsThisYear > NumberOfContestantsLastYear)

            if (NumberOfContestantsThisYear > (NumberOfContestantsLastYear * 2))

                WriteLine("The competition is more than twice as big this year!");
            
            else

                if (NumberOfContestantsThisYear == (NumberOfContestantsLastYear * 2))
                    WriteLine("The competition is twice as big this year!");
                else
                    WriteLine("The competition is bigger than ever!");



        if (NumberOfContestantsThisYear == NumberOfContestantsLastYear)
        {
            WriteLine("There are same number of contestants this year as last year");
        }

        if (NumberOfContestantsLastYear > NumberOfContestantsThisYear)
        {

            WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}

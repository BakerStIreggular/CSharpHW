using System;
using static System.Console;
using System.Globalization;
using System.Diagnostics;
class GreenvilleRevenue
{
    static void Main()
    {
        String ContestantsLastYear, ContestantsThisYear;
        int NumberOfContestantsLastYear, NumberOfContestantsThisYear;
        const double EntranceFee = 25;

        WriteLine("Enter the number of contestants that entered last year >>");
        ContestantsLastYear = ReadLine();
        NumberOfContestantsLastYear = Convert.ToInt32(ContestantsLastYear);
        WriteLine("Enter the number of contestants that entered this year >>");
        ContestantsThisYear = ReadLine();
        NumberOfContestantsThisYear = Convert.ToInt32(ContestantsThisYear);
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
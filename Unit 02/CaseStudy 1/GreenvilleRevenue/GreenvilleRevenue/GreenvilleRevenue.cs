using System;
using static System.Console;
using System.Globalization;
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
        WriteLine("Enter the number of contestants that entered last year >>");
        ContestantsThisYear = ReadLine();
        NumberOfContestantsThisYear = Convert.ToInt32(ContestantsThisYear);
        double Revenue = EntranceFee * NumberOfContestantsThisYear;

        WriteLine("Number of Contestansts Last Year: " + NumberOfContestantsLastYear);
        WriteLine("Number of Contestansts This Year: " + NumberOfContestantsThisYear);
        WriteLine("Estimated Revenue: $" + Revenue);

        if (NumberOfContestantsThisYear > NumberOfContestantsLastYear)
        {
            WriteLine("There are more contestants this year than last year");
        }
        if (NumberOfContestantsThisYear == NumberOfContestantsLastYear)
        {
            WriteLine("There are same number of contestants this year as last year");
        }
        if (NumberOfContestantsLastYear > NumberOfContestantsThisYear)
        {
            WriteLine("There were more contestants last year than this year");
        }
    }
}

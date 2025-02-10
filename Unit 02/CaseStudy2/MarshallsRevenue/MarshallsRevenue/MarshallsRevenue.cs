using System;
using static System.Console;
using System.Globalization;

namespace MarshallsRevenue
{
    internal class MarshallsRevenue
    {
        static void Main(string[] args)
        {
            String ExteriorMurals, InteriorMurals;
            int NumberOfExteriorMurals, NumberOfInteriorMurals;
            const double CostExterior = 750;
            const double CostInterior = 500;

            WriteLine("Enter the number of scheduled exterior murals >> ");
            ExteriorMurals = ReadLine();
            NumberOfExteriorMurals = Convert.ToInt32(ExteriorMurals);
            WriteLine("Enter the number of scheduled interior murals >>");
            InteriorMurals = ReadLine();
            NumberOfInteriorMurals = Convert.ToInt32(InteriorMurals);
            double ExteriorRevenue = CostExterior * NumberOfExteriorMurals;
            double InteriorRevenue = CostInterior * NumberOfInteriorMurals;
            double TotalRevenue = ExteriorRevenue + InteriorRevenue;

            WriteLine("Number of scheduled exterior murals for next month: " + NumberOfExteriorMurals);
            WriteLine("Number of scheduled interior murals for next month: " + NumberOfInteriorMurals);
            WriteLine("Estimated revenue from exterior murals for next month: $" + ExteriorRevenue);
            WriteLine("Estimated revenue from interior murals for next month: $" + InteriorRevenue);
            WriteLine("Estimated total revenue for next month: $" + TotalRevenue);

            if (NumberOfExteriorMurals > NumberOfInteriorMurals)
            {
                WriteLine("There are more exterior murals scheduled for next month");
            }
            if (NumberOfExteriorMurals == NumberOfInteriorMurals)
            {
                WriteLine("There are same number of exterior and interior murals scheduled for next month");
            }
            if (NumberOfInteriorMurals > NumberOfExteriorMurals)
            {
                WriteLine("There were more interior murals scheduled for next month");
            }

        }
    }
}

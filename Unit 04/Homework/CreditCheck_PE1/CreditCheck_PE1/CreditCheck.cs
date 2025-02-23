using System;
using static System.Console;

namespace CreditCheck_PE1
{
    class CreditCheck
    {
        static void Main(string[] args)
        {
            const decimal CreditLimit = 8000;
            decimal CostOfItem;
            String UserInput;

            WriteLine("Please enter the cost of the item" );
            UserInput = ReadLine();
            CostOfItem = Convert.ToDecimal(UserInput);

            if (CostOfItem > CreditLimit)
                Write("Declined: This item is over Credit Limit");
            else
                Write("Approved");

        }
    }
}

// Defines a base class named Customer
// And a child class FrequentCustomer who receives a discount
// Main program demonstrates a customer of each type
using static System.Console;
using System;
class DebugTen01
{
    static void Main()
    {
        Customer aRegularCustomer = new RegularCustomer();
        FrequentCustomer aFrequentCustomer = new FrequentCustomer();
        aRegularCustomer.CustNum = 2514;
        //Captilized the C
        aRegularCustomer.CustBalance = 765.00;
        //Captilized the C
        aFrequentCustomer.CustNum = 5719;
        aFrequentCustomer.CustBalance = 2_500.00;
        aFrequentCustomer.DiscountRate = 0.15;
        //added "" around C2
        WriteLine("\naRegularCustomer #{0} owes {1}",
           aRegularCustomer.CustNum,
           aRegularCustomer.CustBalance.ToString("C2"));
        //added "" around C2 and closing curly bracket on 0
        WriteLine("\naFrequentCustomer #{0} would owe {1} without the discount",
           aFrequentCustomer.CustNum,
           aFrequentCustomer.CustBalance.ToString("C2"));
        //Corrected Spelling on Customer
        double newBal = (1 - aFrequentCustomer.DiscountRate *
           aFrequentCustomer.CustBalance);
        //Captilizied DiscoutRate
        WriteLine("...with {0} discount, customer owes {1}",
           aFrequentCustomer.DiscountRate.ToString("P"), newBal.ToString("C"));
    }
    //added closing curly bracket

}

class Customer
    {
        //changed public
        private int custNum;
        //changed public
        private double custBalance;
        //changed public
        public int CustNum
        {
            get
            {
                return custNum;
            }
            set
            {
                custNum = value;
            }
        }

        //changed public
        public double CustBalance
        {
            get
            {
                return custBalance;
            }
            set
            {
                //Changed + to =
                custBalance = value;
            }
        }
    }
    
    class RegularCustomer : Customer
    {

    }

    //Class added and chaned & to :
    class FrequentCustomer : Customer
    {
        private double discountRate;
        public double DiscountRate
        {
            get
            {
                return discountRate;
            }
            set
            {
                discountRate = value;
            }
        }

    }


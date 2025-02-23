// Program takes a hot dog order
// And determines price
using System;
using static System.Console;
class DebugFour1
{
    static void Main()
    {
        const double BASIC_DOG_PRICE = 2.00;
        const double CHILI_PRICE = 0.69;
        const double CHEESE_PRICE = 0.49;
        String wantChili, wantCheese;
        double price;
        Write("Do you want chili on your dog? ");
        //fixed spelling of Chili
        wantChili = ReadLine();
        Write("Do you want cheese on your dog? ");
        wantCheese = ReadLine();
        //added = because is this is a comprative operator 
        if (wantChili == "Y") 
            //added = because is this is a comprative operator 
           if (wantCheese == "Y")
                //Removed a = sign because it is declaring 
                price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
           else
                //Removed a = sign because it is declaring 
                price = BASIC_DOG_PRICE + CHILI_PRICE;
        else
           //added = because is this is a comprative operator 
           if (wantCheese == "Y")
            //Removed a = sign because it is declaring 
            //added "+ CHEESE_PRICE" 
                price = BASIC_DOG_PRICE + CHEESE_PRICE;
           else
            //Removed a = sign because it is declaring 
                price = BASIC_DOG_PRICE;
        WriteLine("Your total is {0}", price.ToString("C"));
    }
}

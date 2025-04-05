using System;
using static System.Console;
class DebugSeven1
{
    static void Main()
    {
        //Added ()
        DisplayWebAddress();
        //Fixed Line to Cap
        WriteLine("Shop at Shopper's World");
        //Added ()
        DisplayWebAddress();
        WriteLine("The best bargains from around the world");
        //corected Spelling and Added ()
        DisplayWebAddress();
    }
    //Changed from Private to Public Static 
    public static void DisplayWebAddress()
    {
        WriteLine("------------------------------");
        WriteLine("Visit us on the web at:");
        WriteLine("www.shoppersworldbargains.com");
        WriteLine("******************************");
    }
}
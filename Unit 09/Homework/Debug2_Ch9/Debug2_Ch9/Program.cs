// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using static System.Console;
class FixedDebugNine2
{
    static void Main()
    {
        Breakfast special = new Breakfast("French toast", 4.99);// added closing "
        //Display the info about breakfast
        WriteLine(special.INFO);
        // then display today's special
        WriteLine("Today we are having {0} for {1}",//changed the first 1 to 0 so that it would put in the name and not the price
           special.Name, special.Price.ToString("C2"));
    }
}
class Breakfast
{
    public string INFO =
       "Breakfast is the most important meal of the day.";
    public string Name { get; set; }//added get set and captilized name and changed to public
    public double Price { get; set; }//added get set ; and changed to public 
    // Breakfast constructor requires a
    // name, e.g "French toast", and a price
    public Breakfast(string name, double price)
    {
        Name = name;//set Name to be called
        Price = price;//set Price to called
    }
//removed second get sets for name and price
}//added closing bracket

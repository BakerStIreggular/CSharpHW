// Address an envelope using names and addresses
// stored in two parallel arrays
using static System.Console;
using System; 
class FixedDebugSeven2
{
    static void Main()
    {
        string[] addressees = { "Ms. Mary Mack", "Mr. Tom Thumb", "Dr. Seuss" };
        //added Comma between 456 Elm and 87 Maple
        string[] addresses = { "123 Main", "456 Elm", "87 Maple" };
        for (int x = 0; x < addressees.Length; ++x)
            AddressEnvelope(addressees[x], addresses[x]);// changes first variable to addressees  
    }
    private static void AddressEnvelope(string person, string street)
    {
        WriteLine("To : {0}", person);
        WriteLine("     {0}", street);//changed 1 to 0
        for (int x = 0; x < 30; ++x)// Decarled int type x
            Write("-");
        WriteLine();
    }
}

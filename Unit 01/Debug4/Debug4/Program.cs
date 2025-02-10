using static System.Console;
class DebugOne4
{
    static void Main()
    {
        WriteLine("How to play tic tac toe:");
        WriteLine("Draw a three by three grid.");
        //added ; to end of line
        WriteLine("The first player puts an X in any of the nine locations.");
        //corrected spelling of WriteLine
        WriteLine("The second player puts an O in any remaining location.");
        WriteLine("Players alternate turns until one has three of the same symbol in a row");
        //added opening " 
        WriteLine("vertically, horizontally, or diagonally.");
        //changed out lower-case l for upper-case L in WriteLine
        WriteLine("If all nine squares are filled without three in a row,");
        //added opening " 
        WriteLine("the game ends in a tie.");
    }
}
//deleted extra curly bracket



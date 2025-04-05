// Overloaded method gives bonus points
// whether grade is a number or letter
using static System.Console;
using System;
class DebugEight2
{
    static void Main()
    {
        int numericScore = 82;
        string letterScore ="B"; //add ""
        Write("Score was {0}. ", numericScore);
        GiveBonus(ref numericScore);
        WriteLine("Now it is {0}.", numericScore);
        Write("Grade was {0} ", letterScore);//aded {0}
        GiveBonus(ref letterScore);
        WriteLine("Now it is {0} ", letterScore);//aded {0}
    }
    public static void GiveBonus(ref int testScore)//made public, Cap G, changed int ref to ref int 
    {
        const int BONUS = 5;
        testScore += BONUS;// added +
    }
    public static void GiveBonus(ref string letterScore)//made public, changed string ref to ref char
    
    {
        const string BONUS = "+";
        letterScore += BONUS;
    }
}


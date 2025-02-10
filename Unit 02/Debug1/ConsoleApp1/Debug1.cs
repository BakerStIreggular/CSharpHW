// Program compares your name to the name of your boss
using System;
using static System.Console;
class DebugTwo1
{
    static void Main()
    {
        //changed , after bossName to ;
        string name, bossName;
        //Allinged bool
        bool areNamesTheSame;
        //Added opening "
        Write("Enter your name >> ");
        name = ReadLine();
        Write("Hello {0}! Enter the name of your boss >> ", name);
        //Removed one of the =
        bossName = ReadLine();
        areNamesTheSame = String.Equals(name, bossName);
        //changed isNameTheSame to areNamesTheSame
        WriteLine("It is {0} that you are your own boss", areNamesTheSame);
    }
}

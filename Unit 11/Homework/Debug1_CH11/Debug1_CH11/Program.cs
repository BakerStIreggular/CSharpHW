// Handles a Format Exception if user does not enter a number
using System;
using static System.Console;
class DebugEleven01
{
    static void Main()
    {
        double salary = 0;//intialized 
        string salVal;
        bool isValidSalary = false;//intialized
        while (!isValidSalary)
        {
            try
            {
                Write("Enter an employee's salary ");
                salVal = ReadLine();
                salary = Convert.ToDouble(salVal);
                isValidSalary = true;
            }
            catch (FormatException)// removed fe as it was not needed
            {
                WriteLine("You must enter a number for the salary.");
            }
        }
        WriteLine("The salary {0} is valid", salary.ToString("C2"));
    }
}


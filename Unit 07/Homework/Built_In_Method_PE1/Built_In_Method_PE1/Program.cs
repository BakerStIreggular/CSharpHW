using System;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Built_In_Method_PE1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            String UserInputa, UserInputb, UserInputc, UserInputd;
            Char c, d;

            Console.WriteLine( "Enter a whole number");
            UserInputa = ReadLine();
      

            Console.WriteLine("Enter another whole number");
            UserInputb = ReadLine();


            if (UserInputa.Equals(UserInputb))
                WriteLine(UserInputa + " is the same as " + UserInputb);
            else
                WriteLine(UserInputa + "is not the same as" + UserInputb);
            
           
            b = Convert.ToInt32(UserInputb);
            a = Convert.ToInt32(UserInputa);

            if (a > b)
                WriteLine(UserInputa + " is Greater than " + UserInputb);
            if (b > a)
                WriteLine(UserInputb + " is Greater than " + UserInputa);
            else
                WriteLine("We have done this... Look they still equal each other...Moving on");

            Console.WriteLine("Enter a letter");
            UserInputc = ReadLine();


            Console.WriteLine("Enter another letter");
            UserInputd = ReadLine();


            c = Convert.ToChar(UserInputc);

            d = Convert.ToChar(UserInputc);

            WriteLine( c + " & " + d + " are characters... trust me, they are");


            int[] numbers = { 3, 1, 4, 1, 5 };
            Array.Sort(numbers);

        }
    }
}

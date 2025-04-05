using System;
using static System.Console;

namespace Reverse3_1a
{
    class Reverse3
    {
        static void Main()
        {
            // Write your main here
            int firstInt, middleInt, lastInt;
            firstInt = 23;
            middleInt = 45;
            lastInt = 67;
            WriteLine("First: {0}, Second: {1}, Third: {2}", firstInt, middleInt, lastInt);
            Reverse(ref firstInt, ref middleInt, ref lastInt);
            WriteLine("First: {0}, Second: {1}, Third: {2}", firstInt, middleInt, lastInt);
        }

        public static void Reverse(ref int a, ref int b, ref int c)
        {
            int temp = a;
            a = c;
            c = temp;
        }
    }
}

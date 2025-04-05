using System;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse4_1b
{
    class Reverse4
    {
        public static void Reverse(ref int num1, ref int num2, ref int num3, ref int num4)
        {
            int temp;

            temp = num1;
            num1 = num4;
            num4 = temp;

            temp = num2;
            num2 = num3;
            num3 = temp;
        }

        public static void Main(string[] args)
        {
            int a = 23;
            int b = 45;
            int c = 55;
            int d = 67;

            WriteLine("Before swap");
            WriteLine(a + ", " + b + ", " + c + ", " + d);

            // Calling the correct method name "Reverse" instead of "reverse"
            Reverse(ref a, ref b, ref c, ref d);

            WriteLine("After swap");
            WriteLine(a + ", " + b + ", " + c + ", " + d);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug1_Ch8
{
    // GetData() method accepts order number and quantity
    // that are used in the Main() method
    // Price is $3.99 each
    using System;
    using static System.Console;
    class DebugEight1
    {
        static void Main()
        {
            int orderNum, quantity;
            double total;
            const double PRICE_EACH = 3.99;
            GetData(out orderNum, out quantity);// added out to call method and , 
            total = quantity * PRICE_EACH;// Added _
            WriteLine("Order #{0}. Quantity ordered = {1}",
                orderNum, quantity);// Added closeing )
            WriteLine("Total is {0}", total.ToString("C"));
        }
        public static void GetData(out int order, out int amount)//Declared Variable types and changed from private to public
        {
            String s1, s2;
            Write("Enter order number ");
            s1 = ReadLine();//added () to finish readline
            Write("Enter quantity ");
            s2 = ReadLine();//added () to finish readline
            order = Convert.ToInt32(s1);// added . in between Convert and ToInt
            amount = Convert.ToInt32(s2);// added . in between Convert and ToInt
        }
    }
}

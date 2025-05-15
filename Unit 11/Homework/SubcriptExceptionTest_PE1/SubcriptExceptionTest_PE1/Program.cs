using System;

public class SubscriptExceptionTest
{
    public static void Main() 
    {
        bool isNumValue = false;
        int num = 0;
        do
        {
            try
            {
                Console.Write("\nEnter a number (0-9) or 99 to quit: ");
                num = Convert.ToInt32(Console.ReadLine());

                
                if (num == 99)
                {
                    Console.WriteLine("Shuting down");
                    break;  
                }

                
                numList.DisplayValue(num);
                isNumValue = true;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside the bounds of the array.");
                isNumValue = false; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
                isNumValue = false; 
            }
        }
        while (isNumValue);
    }
}
class numList
{
    private static double[] value = { 20.3, 44.6, 32.5, 46.7, 89.6, 67.5, 12.3, 14.6, 22.1, 13.6 };
    public static void DisplayValue(int num)
    {
        
        if (num >= 0 && num < value.Length)
        {
            Console.WriteLine("The value at index {0} is " + value[num].ToString("C"), num);
        }
    }
}

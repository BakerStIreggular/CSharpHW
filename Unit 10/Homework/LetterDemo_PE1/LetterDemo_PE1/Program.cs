using System;

namespace LetterDemo_PE1
{
    public class LetterDemo
    {
        public static void Main()
        {
           
            Letter letterObj = new Letter();

          
            letterObj.Name = "Kayla Welzant";
            letterObj.DateMailed = "2025/04/12";

            Console.WriteLine(letterObj);

          
            Console.WriteLine();

           
            CertifiedLetter certifiedLetterObj = new CertifiedLetter();

          
            certifiedLetterObj.Name = "Fred Clark";
            certifiedLetterObj.DateMailed = "2025/04/12";
            certifiedLetterObj.TrackingNumber = "ZB1234567890";

       
            Console.WriteLine(certifiedLetterObj);
        }
    }
}
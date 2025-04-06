using System;
using System.Globalization;

namespace TestClassifiedAd
{
    
    public class TestClassifiedAd
    {
        public static void Main()
        {
            
            ClassifiedAd ad1 = new ClassifiedAd();
            ad1.Category = "Used Cars";
            ad1.NumWords = 100;

            ClassifiedAd ad2 = new ClassifiedAd();
            ad2.Category = "Help Wanted";
            ad2.NumWords = 60;

          
            Console.WriteLine("The classified ad with {0} words in category {1} costs {2}",
                ad1.NumWords, ad1.Category, ad1.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            Console.WriteLine("The classified ad with {0} words in category {1} costs {2}",
                ad2.NumWords, ad2.Category, ad2.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }
    }

    public class ClassifiedAd
    {
   
        private string _category;
        private int _numWords;

     
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }


        public int NumWords
        {
            get { return _numWords; }
            set { _numWords = value; }
        }

        
        public double Price
        {
            get { return _numWords * 0.09; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLetter_PE2
{
    class salesLetter
    {
        static void Main(string[] args)
        {

            string contactDetails = DisplayContactInfo();

            Console.WriteLine(contactDetails);

            Console.WriteLine("\n");

            Console.WriteLine(contactDetails);

            Console.WriteLine("\n");

            Console.WriteLine(contactDetails);

            Console.ReadLine();


        }
        //Here this method returns the contact details
        static string DisplayContactInfo()
        {
            string contactInfo = "landline:09705705870870478" + "\n" + "cell number:1234567890" + "\n" + "email:xyz@xyz.com";

            return contactInfo;
        }
    }
}

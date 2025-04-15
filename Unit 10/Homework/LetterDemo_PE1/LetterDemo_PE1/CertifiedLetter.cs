
namespace LetterDemo_PE1
{
    public class CertifiedLetter : Letter
    {
      
        public string TrackingNumber { get; set; }

        override public string ToString()
        {
            string result = GetType() + ": \n";
            result += "\tName of the recipient: " + Name + "\n";
            result += "\tDate mailed: " + DateMailed + " \n";
            result += "\tTracking Number: " + TrackingNumber;
            return result;
        }
    }
}

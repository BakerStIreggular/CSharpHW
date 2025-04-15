

namespace LetterDemo_PE1
{
    public class Letter
    {
  
        public string Name { get; set; }

        public string DateMailed { get; set; }

        override public string ToString()
        {
            string result = GetType() + ": \n";
            result += "\tName of the recipient: " + Name + "\n";
            result += "\tDate mailed: " + DateMailed;
            return result;
        }
    }
}

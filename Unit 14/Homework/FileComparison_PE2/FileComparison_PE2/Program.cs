using System;

using System.IO;

class Program

{

    static void Main()

    {

        

        string textFilePath = "MovieQuote.txt";

        string wordFilePath = "MovieQuote.docx";

        

        FileInfo textFileInfo = new FileInfo(textFilePath);

        FileInfo wordFileInfo = new FileInfo(wordFilePath);

        

        if (textFileInfo.Exists && wordFileInfo.Exists)

        {

            

            long textSize = textFileInfo.Length;

            long wordSize = wordFileInfo.Length;

            

            double ratio = (double)textSize / wordSize;

            

            Console.WriteLine($"Size of Quote.txt: {textSize} bytes");

            Console.WriteLine($"Size of Quote.doc: {wordSize} bytes");

            Console.WriteLine($"Ratio of sizes: {ratio:F2}");

        }

        else

        {

            Console.WriteLine("One or both of the files do not exist.");

        }

    }

}

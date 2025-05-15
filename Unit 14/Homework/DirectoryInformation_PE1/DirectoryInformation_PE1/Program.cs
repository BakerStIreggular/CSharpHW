
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DirectoryInformationApplication
{
    
    class DirectoryInformation
    {
        
        static void Main(string[] args)
        {
            
            bool flag = true;

            
            while (flag)
            {
                
                Console.Write("Enter directory : ");

                
                string directory = Console.ReadLine();

                
                if (directory.ToLower() == "end")
                {
                   
                    flag = false;
                }
               
                else if (Directory.Exists(directory))
                {
                   
                    string[] files = Directory.GetFiles(directory);

                    
                    Console.WriteLine("---Files from " + directory + " ----");

                   
                    for (int i = 0; i < files.Length; i++)
                    {
                        
                        Console.WriteLine(files[i]);
                    }
                }
                else
                {
                    
                    Console.WriteLine("Directory " + directory + " does not exists");
                }
            }

            
            Console.ReadKey();
        }
    }
}
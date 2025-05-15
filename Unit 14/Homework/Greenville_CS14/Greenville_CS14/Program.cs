using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
class Contestant
{
    public string Name { get; set; }
    public string Talent { get; set; }
    public double Fee { get; set; }
}

class GreenvilleRevenue
{
   
    static List<Contestant> contestants = new List<Contestant>();
    const string filename = "Greenville.ser";

    static void Main()
    {
        
        LoadContestantData();

        
        EnterContestantData();

        
        SaveContestantData();

        
        DisplayContestantData();

        Console.ReadLine();
    }

    
    static void LoadContestantData()
    {
        if (File.Exists(filename))
        {
            try
            {
                
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    contestants = (List<Contestant>)formatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }
    }

    static void EnterContestantData()
    {
        Console.WriteLine("Enter contestant data. Press Enter to stop.");

        string input;
        do
        {
            Contestant contestant = new Contestant();

        
            Console.Write("Enter contestant name: ");
            contestant.Name = Console.ReadLine();

        
            if (string.IsNullOrWhiteSpace(contestant.Name))
                break;

         
            Console.Write("Enter talent: ");
            contestant.Talent = Console.ReadLine();

          
            Console.Write("Enter fee: ");
            double fee;
            if (double.TryParse(Console.ReadLine(), out fee))
            {
                contestant.Fee = fee;
            }
            else
            {
                Console.WriteLine("Invalid fee input. Skipping this contestant.");
                continue;
            }

           
            contestants.Add(contestant);

        } while (true);
    }

    
    static void SaveContestantData()
    {
        try
        {
            
            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, contestants);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }

   
    static void DisplayContestantData()
    {
        Console.WriteLine("\nContestant Data:");

        
        foreach (var contestant in contestants)
        {
            Console.WriteLine($"Name: {contestant.Name}, Talent: {contestant.Talent}, Fee: {contestant.Fee.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        }
    }
}

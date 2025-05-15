using System;

class SwimmingWaterTemperature
{
    static void Main()
    {
        int temperature;

        
        while (true)
        {
            Console.Write("Enter water temperature in Fahrenheit (enter 999 to quit): ");
            string input = Console.ReadLine();

            
            if (int.TryParse(input, out temperature))
            {
                
                if (temperature == 999)
                {
                    break;
                }

                try
                {
                    
                    bool isComfortable = CheckComfort(temperature);
                    if (isComfortable)
                    {
                        Console.WriteLine($"{temperature} degrees is comfortable for swimming.");
                    }
                    else
                    {
                        Console.WriteLine($"{temperature} degrees is not comfortable for swimming.");
                    }
                }
                catch (ArgumentException e)
                {
                    
                    Console.WriteLine($"Value does not fall within the expected range. {e.Message}");
                }
            }
            else
            {
               
                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
            }
        }
    }

  
    public static bool CheckComfort(int temp)
    {
        
        if (temp < 32 || temp > 212)
        {
            
            throw new ArgumentException("Temperature should be between 32 and 212 degrees Fahrenheit.");
        }

        
        return temp >= 70 && temp <= 85;
    }
}

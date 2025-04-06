using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoccerPlayer_PE1
{
    class SoccerPlayer
    {
        public string Name { get; set; }
        public int JerseyNum { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nJersey Number: {JerseyNum}\nGoals: {Goals}\nAssists: {Assists}";
        }
    }


    class TestSoccerPlayer
    {
        public static void Main(string[] args)
        {
            SoccerPlayer player = new SoccerPlayer
            {
                Name = "Lionel Messi",
                JerseyNum = 10,
                Goals = 700,
                Assists = 500
            };

            Console.WriteLine(player);
        }
    }
}

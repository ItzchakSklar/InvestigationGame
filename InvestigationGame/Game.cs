using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Game
    {
        public static void StartGame()
        {
            Factory factory = Factory.GetInstans();
            factory.StartGame();
            Console.WriteLine("Welcome to the investigation game!");
            Console.WriteLine("Investigation begining...");
            Console.WriteLine("terrorist is waiting in room 9");
            List<Sensor[]> sencors = new List<Sensor[]>();
            sencors.Add(new Sensor[2]);
            while (factory.ListIranAgant.Count > 0)
            {
                
                Console.WriteLine("In which location would you like to set the sensor? (0 - 1)");
                int Choice = ChoiceIntValidat(0, 1);
                if (Choice == -1) continue;
                Console.WriteLine("");
                Console.WriteLine("Available sensor types");
                Console.WriteLine("types: basic thermal");
                string ChoiceType = ChoicestringAvlidat(new string[] { "basic","thermal"});
                if (ChoiceType == "problem") { continue; }
                sencors[0][Choice] = new Sensor(ChoiceType);
                string state = factory.ListIranAgant[0].Activate(sencors[0]);
                Console.WriteLine(state + " matched");
            }
            Console.WriteLine("You win");
        }
        public static int ChoiceIntValidat(int Min, int Max)
        {
            string ChoiceStr = Console.ReadLine();
            int Choice = -1;
            try
            {
                Choice = Convert.ToInt32(ChoiceStr);
            }
            catch
            {
                Console.WriteLine("Not a good fotmat");
                return -1;
            }
            if (Choice <= Max && Choice >= Min)
                return Choice;
            else Console.WriteLine("Choice not in range");
            return -1;
            
        }
        public static string ChoicestringAvlidat(string[] AvlidatCensor)
        {
            string Choice = Console.ReadLine();
            Choice = Choice.ToLower();
            if (!AvlidatCensor.Contains(Choice))
            {
                Console.WriteLine("not a goot type");
                return "problem";
            }
            return Choice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            List<SensorBasic> sensors = new List<SensorBasic>();
            sensors.Add(null);
            sensors.Add(null); 
            if (Game.Check)
                Print.PrintList(factory.ListIranAgant[0].Weakness);
            while (factory.ListIranAgant.Count > 0)
            {
                
                Console.WriteLine("In which location would you like to set the sensor? (0 - 1)");
                int Choice = ChoiceIntValidat(0, 1);
                if (Choice == -1) continue;
                Console.WriteLine("Available sensor types");
                Console.Write("types: ");
                Print.PrintList(Factory.ListAvilbleSensor);
                string ChoiceType = ChoicestringAvlidat(Factory.ListAvilbleSensor);
                if (ChoiceType == "problem") { continue; }
                sensors[Choice] = Factory.CreatSensor(ChoiceType);
                if (Game.Check)
                {
                    Console.Write("This is sensors: ");
                    Print.PrintList(sensors);
                    Console.Write("This is wiknnes: ");
                    Print.PrintList(factory.ListIranAgant[0].Weakness);
                }
                string state = factory.ListIranAgant[0].Activate(sensors);
                Console.WriteLine(state + " matched");
                ChackAgaint(state, factory.ListIranAgant);
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
        public static void ChackAgaint(string state,List<IranianAgint>  ListSensor)
        {
            if (state[0] == state[2])
                ListSensor.RemoveAt(ListSensor.Count - 1);
        }
        
        public static bool Check = true;
    }
}

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
            List<SensorBasic> sensors = new List<SensorBasic>();
            int room = 0;
            while (factory.ListIranAgant.Count > 0)
            {
                room++;
                RestSensors(sensors);
                Console.WriteLine($"terrorist is waiting in room {room}");
                if (Game.Check) printAgint(factory.ListIranAgant, room);
                int numOfAgint = factory.ListIranAgant.Count;
                while (factory.ListIranAgant.Count == numOfAgint)
                {
                    if (Game.Check)
                    {
                        Console.WriteLine();
                        Console.Write("This is sensors: ");
                        Print.PrintList(sensors);
                        Console.Write("This is wiknnes: ");
                        Print.PrintList(factory.ListIranAgant[0].Weakness);
                        Console.WriteLine();
                    }
                    Console.WriteLine($"In which location would you like to set the sensor? (0 - {factory.ListIranAgant[0].Weakness.Length - 1})");
                    int Choice = ChoiceIntValidat(0, factory.ListIranAgant[0].Weakness.Length - 1);
                    if (Choice == -1) continue;
                    Console.WriteLine("Available sensor types");
                    Console.Write("types: ");
                    Print.PrintList(Factory.ListAvilbleSensor);
                    string ChoiceType = ChoicestringAvlidat(Factory.ListAvilbleSensor);
                    if (ChoiceType == "problem") { continue; }
                    sensors[Choice] = Factory.CreatSensor(ChoiceType);
                    string state = factory.ListIranAgant[0].Activate(sensors);
                    Console.WriteLine(state + " matched");
                    ChackAgaint(state, factory.ListIranAgant);
                }
                Console.WriteLine($"you win room {room}");
                Console.WriteLine();
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
                ListSensor.RemoveAt(0);
        }
        public static List<SensorBasic> RestSensors(List<SensorBasic> sensors)
        {
            if (sensors.Count() == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    sensors[i] = null;
                }
            }
            else
            {
                for (int i = sensors.Count; i < 8; i++)
                {
                    sensors.Add(null);
                }
            }
            return sensors;
        }

        public static void printAgint(List<IranianAgint>ListIranAgant,int room)
        {
            if (Game.Check)
                Console.WriteLine();
                for (int i = 0; i < ListIranAgant.Count; i++)
                {
                    Console.WriteLine("agine" + (i + room));
                    Console.WriteLine(ListIranAgant[i].GetType());
                    Print.PrintList(ListIranAgant[i].Weakness);
                    Console.WriteLine();
                }
        }
        
        public static bool Check = true;
    }
}

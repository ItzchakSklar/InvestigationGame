using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Print
    {
        public static void PrintList(List<string> list)
        {
            foreach (string item in list) Console.Write(item +", ");
            Console.WriteLine();
        }
        public static void PrintList(SensorBasic[] list)
        {
            foreach (SensorBasic item in list) 
            {
                if (item != null)
                    Console.Write(item + ", ");
                
            }
            Console.WriteLine();
        }
        public static void PrintList(List<SensorBasic> list)
        {
            foreach (SensorBasic item in list)
            {
                if (item != null)
                    Console.Write(item + ", ");                
            }
            Console.WriteLine();

        }
        public static void PrintList(string[] list)
        {
            foreach (string item in list)
            {
                if (item != null)
                    Console.Write(item + ", ");
            }
            Console.WriteLine();

        }
    }
}

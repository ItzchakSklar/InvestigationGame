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
        public static void PrintList(Sensor[] list)
        {
            foreach (Sensor item in list) 
            {
                if (item != null)
                    Console.Write(item.Name() + ", ");
                
            }
            Console.WriteLine();
        }
        public static void PrintList(List<Sensor> list)
        {
            foreach (Sensor item in list)
            {
                if (item != null)
                    Console.Write(item.Name() + ", ");                
            }
            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InvestigationGame
{
    internal class IranianAgint
    {
        public SensorBasic[] Weakness;
        public string Name;
        public int Level;
        string Orgnization;
        public IranianAgint(SensorBasic[] ListSensor,string name,int level,string orgnization)
        {
            Weakness = ListSensor;
            Name = name;
            Level = level;
            Orgnization = orgnization;
        }
        public virtual string Activate(List<SensorBasic> sensor)
        {
            int Mach = 0;
            for (int i = 0; i < Weakness.Length; i++)
            {
                if (sensor[i] != null)
                {
                   if (Weakness[i].ToString().Equals(sensor[i].ToString()))
                       Mach++;
                   int[] activ = sensor[i].Activate();
                   if (Game.Check) { Console.WriteLine($"{i} {sensor[i].ToString()} activate"); Print.PrintList(activ); }
                   if (activ[0] == activ[1])
                   {
                        sensor[i] = null;
                   }
                }
            }
            return $"{Mach}/{Weakness.Length}";
        }
        public override string ToString()
        {
            return "foots soldier";
        }
        
    }
}

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
            string remuv = "n";
            for (int i = 0; i < sensor.Count; i++)
            {
                if (sensor[i] != null)
                {
                    if (Weakness[i].ToString().Equals(sensor[i].ToString()))
                        Mach++;
                    if (sensor[i] is SensorPulseMotion)
                    { 
                        int[] activ = sensor[i].Activate();
                        if (activ[0] == activ[1])
                        {
                            remuv += i;
                        }
                    }
                }
            }
            return $"{Mach}/{Weakness.Length}"+remuv;
        }
        public override string ToString()
        {
            return "foots soldier";
        }
        
    }
}

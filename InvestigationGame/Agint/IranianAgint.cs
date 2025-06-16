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
        public List<string> Weakness = new List<string>();
        public IranianAgint(int Sensors = 2)
        {
            Weakness = ListNameSensor(Sensors);
        }
        public string Activate(List<SensorBasic> sensor)
        {
            int Mach = 0;
            for (int i = 0; i < sensor.Count; i++)
            {
                if (sensor[i] != null)
                    if (Weakness[i].Equals(sensor[i].ToString()))
                        Mach++;
                
            }
            return $"{Mach}/{Weakness.Count}";
        }
        public List<string> ListNameSensor(int sensor)
        {
            List<string> ListNameSensor = new List<string>();
            Random random = new Random();
            int rand;
            for (int i = 0; i < sensor; i++)
            {
                rand = random.Next(0, Game.ListAvilbleSensor.Length);
                ListNameSensor.Add(Game.ListAvilbleSensor[rand]);
            }
            return ListNameSensor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Sensor
    {
        static string[] AvaibleSensors = { "basic", "thermal" };
        int activate = 0; 
        string name = null;
        public Sensor(string Type = null)
        {
            Random rand =  new Random();
            if (Type == null&&!AvaibleSensors.Contains(Type))  
                name = AvaibleSensors[rand.Next(0, AvaibleSensors.Length)];
            else
                name = Type;
        }
        public int Activate()
        {
            activate++;
            return activate;
        }
        public string Name()
        { return name; }

    }
}

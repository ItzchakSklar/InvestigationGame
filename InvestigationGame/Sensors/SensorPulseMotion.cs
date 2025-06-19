using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SensorPulseMotion : SensorBasic
    {
        //private static string[] PossibleNames = { "pulse", "motion" };  
        string SensorName;
        int activate = 0;
        int MaxActivate = 3;
        public SensorPulseMotion(string sensorName)
        {
            SensorName = sensorName;
        }
        public override string ToString() { return SensorName; }
        public override int[] Activate()
        {
            activate++;
            return new int[2] { activate, MaxActivate };
        }
    }
}

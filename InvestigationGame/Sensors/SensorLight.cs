using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SensorLight : SensorThermal
    {
        public override string ToString()
        {
            return "light";
        }
        public override string Ability()
        {
            return "Exposed rank And Association";
        }
    }
}

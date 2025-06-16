using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SensorThermal : SensorBasic
    {
        public override string ToString() => "thermal";
        public virtual string Ability()
        {
            return "Exposed sensor";
        }    
    }
}

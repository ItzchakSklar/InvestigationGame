using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SensorMagnetic : SensorBasic
    {
        int Black = 2;
        public override string ToString() => "magnetic";
        public int BlackAttake()
        {
            if (Black > 0)
            {
                --Black;
                return 1; 
            }
            return 0;
        }
    }
}

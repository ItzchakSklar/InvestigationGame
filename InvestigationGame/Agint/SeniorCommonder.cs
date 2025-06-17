using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SeniorCommonder: SquadLeader
    {
        public SeniorCommonder(SensorBasic[] ListSensor, string name, int level, string orgnization) : base(ListSensor, name, level, orgnization) { }
        public override string Activate(List<SensorBasic> sensor)
        {
            int rand = -1;
            BreakCounter++;
            if (BreakCounter == BreakAny)
            {
                BreakCounter = 0;
                Random random = new Random();
                rand = random.Next(0, Weakness.Length);
                rand *= 10;
                rand = random.Next(0, Weakness.Length);
            }
            string remuv = base.Activate(sensor).Substring(3);
            if (rand != -1)
                if (remuv.Contains(rand.ToString()[1]))
                    rand /= 10;
            if (remuv.Contains(rand.ToString()[0]))
                if (rand.ToString().Length == 2)
                    rand %= 10;
                else
                    rand = -1;
            if (rand != -1)
                    return $"{base.Activate(sensor)}{rand}";
            return base.Activate(sensor);
        }
        public override string ToString() => "senior commonder";
    }
}

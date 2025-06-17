using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SquadLeader : IranianAgint
    {
        static protected int BreakAny = 3;
        protected int BreakCounter = 0;
        public SquadLeader(SensorBasic[] ListSensor, string name, int level, string orgnization) :base(ListSensor, name, level, orgnization){ }
        public override string Activate(List<SensorBasic> sensor)
        {
            int rand = -1;
            BreakCounter++;
            if (BreakCounter == BreakAny)
            {
                BreakCounter = 0;
                Random random = new Random();
                rand = random.Next(0, Weakness.Length); 
            }
            string remuv = base.Activate(sensor).Substring(3);
            if (rand != -1 && !remuv.Contains(rand.ToString()))
                return $"{base.Activate(sensor)}{rand}";
            return base.Activate(sensor);
        }
        public override string ToString() => "squad leader";
    }
}

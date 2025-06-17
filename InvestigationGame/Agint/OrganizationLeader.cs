using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class OrganizationLeader : SquadLeader
    {
        public OrganizationLeader(SensorBasic[] ListSensor, string name, int level, string orgnization) : base(ListSensor, name, level, orgnization) { }
        public override string ToString()
        {
            return "organization leader";
        }
    }
}

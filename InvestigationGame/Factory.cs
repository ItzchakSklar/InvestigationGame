using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Factory
    {
        private static Factory Instans = null;
        public List<IranianAgint> ListIranAgant = new List<IranianAgint>();
        private Factory() { }
        public static Factory GetInstans()
        {
            if (Instans == null)
                Instans = new Factory();
            return Instans;
        }
        public void creatIranianAgint()
        {
            ListIranAgant.Add(new IranianAgint());
        }
        public void StartGame()
        {
            creatIranianAgint();
        }
    }
}

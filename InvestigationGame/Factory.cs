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
        public static SensorBasic CreatSensor(string Type)
        {
            switch (Type)
            {
                case ("basic"):
                    return new SensorBasic();
                case ("thermal"):
                    return new SensorThermal();
                case ("pulse"):
                    return new SensorPulseMotion("pulse");
                case ("motion"):
                    return new SensorPulseMotion("motion");
                case ("magnetic"):
                    return new SensorMagnetic();
                case ("singal"):
                    return new SensorSingal();
                case ("light"):
                    return new SensorLight();
            }
            Console.WriteLine("a problem in Factory.CreatSensor()");
            return new SensorBasic();
        }
        public void StartGame()
        {
            creatIranianAgint();
        }
    }
}

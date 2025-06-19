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
        Random random = new Random();
        private Factory() { }
        public static Factory GetInstans()
        {
            if (Instans == null)
                Instans = new Factory();
            return Instans;
        }
        public void creatIranianAgint()
        {
            int RandName = random.Next(0, AvailbleNames.Length);
            int RandLevel = random.Next(0, 5);
            int RandOrgnization = random.Next(0, AvailbleOrgniztion.Length);
            ListIranAgant.Add(new IranianAgint(ListSensor(2,ListAvilbleSensor), AvailbleNames[RandName], RandLevel, AvailbleOrgniztion[RandOrgnization]));
        }
        public void creatSquadLeader()
        {
            int RandName = random.Next(0, AvailbleNames.Length);
            int RandLevel = random.Next(0, 5);
            int RandOrgnization = random.Next(0, AvailbleOrgniztion.Length);
            ListIranAgant.Add(new SquadLeader(ListSensor(4, ListAvilbleSensor), AvailbleNames[RandName], RandLevel, AvailbleOrgniztion[RandOrgnization]));
        }
        public void creatSeniorCommonder()
        {
            int RandName = random.Next(0, AvailbleNames.Length);
            int RandLevel = random.Next(0, 5);
            int RandOrgnization = random.Next(0, AvailbleOrgniztion.Length);
            ListIranAgant.Add(new SeniorCommonder(ListSensor(6, ListAvilbleSensor), AvailbleNames[RandName], RandLevel, AvailbleOrgniztion[RandOrgnization]));
        }
        public void creatOrganizationLeader()
        {
            int RandName = random.Next(0, AvailbleNames.Length);
            int RandLevel = random.Next(0, 5);
            int RandOrgnization = random.Next(0, AvailbleOrgniztion.Length);
            ListIranAgant.Add(new OrganizationLeader(ListSensor(8, ListAvilbleSensor), AvailbleNames[RandName], RandLevel, AvailbleOrgniztion[RandOrgnization]));
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
            for (int i = 0; i < 2; i++)
            {
                int rand = random.Next(0, 4);
                switch (rand)
                {
                    case (0):
                        creatIranianAgint();
                        break;
                    case (1):
                        creatSquadLeader();
                        break;
                    case (2):
                        creatSeniorCommonder();
                        break;
                    case (3):
                        creatOrganizationLeader();
                        break;
                }
            }
        }
        public SensorBasic[] ListSensor(int sensor, string[] ListAvilbleSensor)
        {
            SensorBasic[] ListSensor = new SensorBasic[sensor];
            int rand;
            for (int i = 0; i < sensor; i++)
            {
                rand = random.Next(0, ListAvilbleSensor.Length);
                ListSensor[i] = CreatSensor(ListAvilbleSensor[rand]);
            }
            return ListSensor;
        }
        public static string[] AvailbleNames = {"Ahmad", "Mohammad", "Ali", "Yousef", "Omar", "Samir", "Amir", "Abdallah", "Karim", "Munir","Fatma", "Hanan", "Noor", "Lina", "Rana", "Sabreen", "Rasha", "Najah", "Abeer", "Dima"};
        public static string[] AvailbleOrgniztion = {"Hamas","Hezbollah","Al-Qaeda","ISIS"};
        public static string[] ListAvilbleSensor = new string[7] { "basic", "thermal", "pulse", "motion", "magnetic", "singal", "light" };
    }
}

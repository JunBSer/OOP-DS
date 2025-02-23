using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassViewer.Internal.Models
{
    public class Car: LandTransport
    {
        private string FuelType{ get; set; }
        protected int FuelLvl{ get; set; }
        

        public Car(string name, int speed, string fuelType, int fuelLvl)
        : base(name, speed,  4)
        {
            this.FuelType = fuelType;
            this.FuelLvl = fuelLvl;
            
        }

        public override string DisplayInfo()
        {
            string baseInfo=base.DisplayInfo();
            return $"{baseInfo}Fuel type: {FuelType}\nFuel LVL: {FuelLvl}\n";
        }

        public string Refuel()
        {
            int resFuelLvl = FuelLvl + stdFuelReplenishment;
            if (resFuelLvl> 100)
                return "Fuel lvl is too high";
            
            FuelLvl =resFuelLvl;
            
            return $"{Name} refuel {FuelType} by {stdFuelReplenishment}l";
        }

        public override string Drive()
        {
            if (FuelLvl - stdFuelConsumption < 0) 
            {
                    FuelLvl = 0; return $"{Name} has no fuel";
            }

            FuelLvl -= stdFuelConsumption;
            
            return base.Drive();
        }

        public override void Draw(Graphics g)
        {
            LoadImage("car");
            base.Draw(g);
        }
    }
}
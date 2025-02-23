using System;
using System.Drawing;
using System.Windows.Forms;


namespace ClassViewer.Internal.Models
{
    public class HybridCar : Car
    {
        private int BatteryLvl{ get; set; }
        private bool IsOnFuel { get; set; } = true;

        public HybridCar(string name, int speed,  int fuelLvl, int batteryLvl)
            : base(name, speed, "Electricity-Fuel", fuelLvl)
        {
            this.BatteryLvl = batteryLvl;
        }

        public override string DisplayInfo()
        {
            string baseInfo = base.DisplayInfo();
            return $"{baseInfo}Battery capacity: {BatteryLvl}%\nHybrid car is on fuel: {IsOnFuel}";
        }

        public string ChargeBattery()
        {
            BatteryLvl = 100;
            return "Charging battery";
        }

        public string SwitchFuelType()
        {
            IsOnFuel = !IsOnFuel;
            return "Fuel type switched";
        }

        public override string Drive()
        {
            if (IsOnFuel)
            {
                if (FuelLvl - stdFuelConsumption < 0)
                {
                    FuelLvl = 0; 
                    return $"{Name} has no fuel";
                }

                FuelLvl -= stdFuelConsumption;
            }
            else
            {
                if (BatteryLvl - stdChargeConsumption < 0)
                {
                    BatteryLvl = 0;
                    return $"{Name} has no charge";
                }
                
                BatteryLvl -= stdChargeConsumption;
            }
            
            this.Move();
            return $"{Name} is driving on the road\n";
      
        }

        public override void Draw(Graphics g)
        {
            LoadImage("electrocar");
            DrawTransport(g);
        }
    }
}
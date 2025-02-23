using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassViewer.Internal.Models
{
    public class Ship:WaterTransport
    {
        private int DeckCount { get; }
        private int FuelLvl{ get; set; }

        public Ship(string name, int speed,  int displacement, int deckCount, int fuelLvl)
            : base(name, speed, displacement)
        {
            this.DeckCount = deckCount;
            this.FuelLvl = fuelLvl;
            LoadImage("ship");
        }

        public override string DisplayInfo()
        {
            string baseInfo = base.DisplayInfo();
            return $"{baseInfo}Deck count: {DeckCount}\nFuel level: {FuelLvl}\n";
        }

        public string Toot()
        {
           return $"{Name} is tooting";
        }

        public override string Sail()
        {
            if (FuelLvl - stdFuelConsumption < 0) { 
                FuelLvl = 0; 
                return $"{Name} has no fuel";
            }

            FuelLvl -= stdFuelConsumption;
            
            return base.Sail();
        }
        
        public string Refuel()
        {
            FuelLvl += stdFuelReplenishment;
            
            return $"{Name} refilled fuel by {stdFuelReplenishment}l";
        }
        
        public override void Draw(Graphics g)
        {
            LoadImage("ship");
            base.Draw(g);
        }
    }
}
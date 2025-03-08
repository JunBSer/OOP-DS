namespace ClassViewer.Internal.Models
{
    public class Airplane: Aircraft
    {
        private int WingSpan{ get; }
        private int FuelLvl{ get; set; }

        public Airplane(string name, int speed,  int maxAttitude, int wingSpan, int fuelLvl)
            : base(name,speed, maxAttitude)
        {
            this.WingSpan = wingSpan;
            this.FuelLvl = fuelLvl;
          
        }

        public override string DisplayInfo()
        {
            string baseInfo = base.DisplayInfo();
            return $"{baseInfo}WingSpan: {WingSpan}\nFuel LVL: {FuelLvl}";
        }


        public override string Fly()
        {
            if (FuelLvl - stdFuelConsumption <= 0)
            {
                FuelLvl = 0;
                if (Y>0)
                    return $"{Name} has no fuel (crush)";
                else
                    return $"{Name} has no fuel";   
            }
            
            FuelLvl -= stdFuelConsumption;
            return base.Fly();
        }

        public string Refuel()
        {
            if (Y > 0)
                return "Firstly you need to land";
            FuelLvl += stdFuelReplenishment;
            
            return $"{Name}  refilled fuel by {stdFuelReplenishment}l";
        }
        
        public override void Draw(Graphics g)
        {
            LoadImage("plane");
            base.Draw(g);
        }
    }
}
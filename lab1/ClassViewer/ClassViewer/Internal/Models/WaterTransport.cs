namespace ClassViewer.Internal.Models
{
    public abstract class WaterTransport:Transport
    {
        private int WaterDisplacement{get;}

        protected WaterTransport(string name, int speed, int waterDisplacement)
            : base(name, speed)
        {
            this.WaterDisplacement = waterDisplacement;
        }

        public override string DisplayInfo()
        {
            string baseInfo = base.DisplayInfo();
            return $"{baseInfo}Water displacement: {WaterDisplacement}\n";
        }

        public virtual string Sail()
        {
            this.Move();
            return $"{Name} is sailing on the water";
        }
        
    }
}
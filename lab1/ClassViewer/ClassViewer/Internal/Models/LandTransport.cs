namespace ClassViewer.Internal.Models
{
    public abstract class LandTransport: Transport
    {
        private int Wheels { get;}

        protected LandTransport(string name, int speed,  int wheels)
            :base(name, speed)
        {
            this.Wheels = wheels;
        }

         public override string DisplayInfo()
         {
             string baseInfo = base.DisplayInfo();
             return $"{baseInfo}Wheels count: {Wheels}\n";
         }

        public virtual string Drive()
        {
            this.Move();
            return $"{Name} is driving on the road\n";
        }

    }
}
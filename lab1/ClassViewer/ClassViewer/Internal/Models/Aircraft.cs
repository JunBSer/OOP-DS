using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassViewer.Internal.Models
{
    public abstract class Aircraft: Transport
    {
        private int MaxAttitude { get; }

        protected Aircraft(string name, int speed, int maxAttitude)
            : base(name, speed)
        {
            this.MaxAttitude = maxAttitude;
        }

        public override string DisplayInfo()
        {
           string baseInfo = base.DisplayInfo();
           return $"{baseInfo}Max Attitude: {MaxAttitude}\n" ;
        }

        public string TakeOff()
        {     
                this.Y += 100;
                return $"{Name} taking off";
        }

        public string Land()
        {
                this.Y = 0;
                return $"{Name} land";
        }

        public virtual string Fly()
        {
            if (Y == 0)
                return "Firstly take it off";
            
            Move();
            return $"{Name} is flying";
        }
        
    }
}
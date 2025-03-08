namespace ClassViewer.Internal.Models
{
    public abstract class Transport
    {
        protected const int stdFuelConsumption = 8;
        protected const int stdFuelReplenishment = 25;
        protected const int stdChargeConsumption = 15;
        
        private static readonly Size DefaultImgSize = new Size(150, 80);
        private static readonly Point DefaultLocation = new Point(0, 0);
        private static readonly Point ImageLocation = new Point(10, 230);
        
        public string Name {get;}
        private int Speed;
        private Bitmap Image;

        private int X;
        protected int Y;


        public Transport()
        {
            Console.WriteLine("Empty constructor");
        }
        
        protected Transport(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
            InitTransport();
        }

        protected void Move()
        {
            X += Speed;
        }
        

        public virtual string DisplayInfo()
        {
            return $"Name: {Name}\nSpeed: {Speed}\nCoord X: {X}\nCoord Y: {Y}\n";
        }

        public virtual void Draw(Graphics g)
        {
            DrawTransport(g);
        }

        protected void DrawTransport(Graphics g)
        {
            if (Image != null) 
                g.DrawImage(Image, ImageLocation);
        }

        protected void LoadImage(string path)
        {
            string fullPath = $"..\\..\\..\\Resources\\{path}.jpg";
            
            if (Image!=null)
                Image.Dispose();
            
            Image = new Bitmap(fullPath);
            if (Image == null)
            {
                Console.WriteLine("Image is null");
                    return;
            }

            Image = new Bitmap(Image, DefaultImgSize);
           
        }
        
        private void InitTransport()
        {
            X = DefaultLocation.X;
            Y = DefaultLocation.Y;
        }
    }
}
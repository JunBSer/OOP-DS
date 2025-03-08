using ClassViewer.Internal;
using ClassViewer.Internal.Models;

namespace ClassViewer
{
    public partial class Form1 : Form
    {
        public TransportList transports = new TransportList();

        public Form1()
        {
            InitializeComponent();
            
            Transport car = new Car("Toyota Supra", 320,  "Disel", 50);
            Transport ship = new Ship("Titanik", 100, 200, 3, 500);
            Transport airplane = new Airplane("Boeing", 900, 67, 5,100);
            Transport hybrid = new HybridCar("EVOLUTE I-SPACE", 290, 100, 60);
            
            transports.AddTransport(car);
            transports.AddTransport(ship);
            transports.AddTransport(airplane);
            transports.AddTransport(hybrid);

           
            objectPicker.DataSource = transports.GetTransports();
            objectPicker.DisplayMember = "Name";
            
            infoTbx.Multiline = true; 
            infoTbx.ScrollBars = ScrollBars.Vertical; 
            infoTbx.WordWrap = true; 
            
        }

        
        private void objectPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            methodPicker.Items.Clear();

            if (objectPicker.SelectedItem is Transport transport)
            {
                methodPicker.Items.Add("DisplayInfo");
                methodPicker.Items.Add("Draw");

                if (transport is LandTransport land)
                {
                    methodPicker.Items.Add("Drive");
                    
                    if (land is Car car)
                    {
                        methodPicker.Items.Add("Refuel");

                        if (car is HybridCar hybrid)
                        {
                            methodPicker.Items.Add("ChargeBattery");
                            methodPicker.Items.Add("SwitchFuelType");
                        }
                    }
                }
                
                
                
                if (transport is Aircraft aircraft)
                {
                    methodPicker.Items.Add("Fly");
                    methodPicker.Items.Add("Land");
                    methodPicker.Items.Add("TakeOff");
                    
                    if (aircraft is Airplane airplane)
                        methodPicker.Items.Add("Refuel");
                }

                if (transport is WaterTransport waterTransport)
                {
                    methodPicker.Items.Add("Sail");

                    if (waterTransport is Ship sail)
                    {
                        methodPicker.Items.Add("Toot");
                        methodPicker.Items.Add("Refuel");
                    }
                }
                
            }
        }

       
        private void methodPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteMethod(); 
        }

       
        private void ExecuteMethod()
        {
            if (objectPicker.SelectedItem == null || methodPicker.SelectedItem == null)
                return;
            
            Transport transport = objectPicker.SelectedItem as Transport;
            string selectedMethod = methodPicker.SelectedItem.ToString();
            string result = "";


            switch (selectedMethod)
            {
                case "DisplayInfo":
                    result = transport.DisplayInfo();
                    break;
                
                case "Draw":
                    break;
                
                case "Drive":
                    if (transport is LandTransport land) 
                        result=land.Drive();
                    break;
                
                case "Refuel":
                    if (transport is Car car)
                        result=car.Refuel();
                    else if (transport is Airplane airplane)
                        result = airplane.Refuel();
                    else if (transport is Ship ship)
                        result = ship.Refuel();
                    break;
                
                case "SwitchFuelType":
                    if (transport is HybridCar hybrid)
                        result=hybrid.SwitchFuelType();
                    break;
                
                case "ChargeBattery":
                    if (transport is HybridCar hCar)
                        result=hCar.ChargeBattery();
                    break;
                
                case "Sail":
                    if (transport is WaterTransport wTransport)
                        result=wTransport.Sail();
                    break;
                
                case "TakeOff":
                    if (transport is Aircraft aircraft)
                        result=aircraft.TakeOff();
                    break;
                
                case "Land":
                    if (transport is Aircraft aTransport)
                        result=aTransport.Land();
                    break;
                
                case "Fly":
                    if (transport is Aircraft aTr)
                        result=aTr.Fly();
                    break;
                
                case "Toot":
                    if (transport is Ship wShip)
                        result=wShip.Toot();
                    break;
                    
            }
            leftPanel.Invalidate(); 
            infoTbx.Text = result.Replace("\n", Environment.NewLine);
        }

       
        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {
            if (objectPicker.SelectedItem is Transport transport && 
                methodPicker.SelectedItem!=null && methodPicker.SelectedItem.ToString() == "Draw") 
            {
                transport.Draw(e.Graphics); 
            }
        }
    }
}

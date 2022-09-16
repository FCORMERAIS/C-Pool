namespace CSharpDiscovery.Quest04 {
    public class Car : Vehicule {
        public string Model {get; set;}

        public Car() {
            Model = "Unknown";
        }

        public Car(string model,string Brand,string Color, int CurrentSpeed=0) : base(Brand,Color,CurrentSpeed) {
            this.Model = model;
            CurrentSpeed = CurrentSpeed;
            Brand = Brand;
            Color = Color;
        }

        public override string ToString(){
            return this.Color+" "+this.Brand+" "+this.Model;
        }
    }
}
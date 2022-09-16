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

        public override void Accelerate(int addSpeed) {
            this.CurrentSpeed += addSpeed;
            if (this.CurrentSpeed > 180) {this.CurrentSpeed = 180;}
        }

        public override void Brake(int lessSpeed) {
            this.CurrentSpeed -= lessSpeed;
            if (this.CurrentSpeed < 0) {this.CurrentSpeed = 0;}
        }
    }
}
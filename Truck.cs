namespace CSharpDiscovery.Quest04 {
    public class Truck : Vehicule{
        public int Tonnage {get;set;}

        public Truck() {
            Tonnage = 0;
        }
        
        public Truck(int tonnage,string Brand,string Color,int CurrentSpeed = 0) : base(Brand,Color,CurrentSpeed) {
            Tonnage = tonnage;
            Brand =Brand;
            Color = Color;
            CurrentSpeed = CurrentSpeed;
        }

        public override string ToString() {
            return this.Color+" " +this.Brand+" "+this.Tonnage+"T Truck";
        }

        
        public override void Accelerate(int addSpeed) {
            this.CurrentSpeed += addSpeed;
            if (this.CurrentSpeed > 100) {this.CurrentSpeed = 100;}
        }

        public override void Brake(int lessSpeed) {
            this.CurrentSpeed -= lessSpeed;
            if (this.CurrentSpeed < 0) {this.CurrentSpeed = 0;}
        }
    }
}
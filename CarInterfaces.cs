namespace CSharpDiscovery.Quest04 {
    public interface IThermalCar 
    {
        int FuelLevel {get=>100;set{}}
        void FillUp();
        int GetFuelLevel();
    }
    public interface IElectricCar 
    {
        int BatteryLevel{get=>100;set{}}
        void Recharge();
        int GetBatteryLevel();
    }
}
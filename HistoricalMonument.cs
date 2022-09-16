using System;
namespace CSharpDiscovery.Quest03{
    public class HistoricalMonument : PointOfInterest {
        public int BuildYear {get;set;}

        public override String ToString(){
            return this.Name+" is a historical monument built in "+this.BuildYear;
        }

        public HistoricalMonument(){}

        public HistoricalMonument(String Name, Double Latitude, Double Longitude, int buildYear) : base(Name,Latitude,Longitude)
        {
            this.BuildYear = buildYear;
        }
    }
}
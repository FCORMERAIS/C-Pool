using System;
namespace CSharpDiscovery.Quest03{
    public class PointOfInterest {
        public Double Latitude{get;set;}
        public Double Longitude{get;set;}
        public String Name {get;set;} 
        public static String GoogleMapsUrlTemplate 
        {
            get {return "https://www.google.com/maps/place/{0}/@{1},{2},15z/"; }
        }

    public PointOfInterest(){
        Name = "Bordeaux Ynov Campus";
        Latitude = 44.854186;
        Longitude = -0.5663056;
    }

    public PointOfInterest(String name, Double latitude, Double longitude) {
        this.Name = name;
        this.Latitude = latitude;
        this.Longitude = longitude;
    }

    }
}
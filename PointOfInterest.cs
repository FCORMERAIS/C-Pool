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
        public string GetGoogleMapsUrl() {
            return "https://www.google.com/maps/place/"+this.Name.Replace(" ", "+")+"/@"+this.Latitude+","+this.Longitude+",15z/";
        }

        public override string ToString(){
            return this.Name+" (Lat="+this.Latitude+", Long="+this.Longitude+")";
        }

        public int GetDistance(PointOfInterest other)
        {
        Double R = 6371;
        Double dLat = Radians(other.Latitude - this.Latitude);
        Double dLon = Radians(other.Longitude - this.Longitude);
        Double lat1 = Radians(other.Latitude);
        Double lat2 = Radians(this.Latitude);

        Double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        Double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        Double d = R * c;
        return (int)d+1;
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
        Double R = 6371;
        Double dLat = Radians(p1.Latitude - p2.Latitude);
        Double dLon = Radians(p1.Longitude - p2.Longitude);
        Double lat1 = Radians(p1.Latitude);
        Double lat2 = Radians(p2.Latitude);
        Double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        Double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        Double d = R * c;
        return (int)d+1;
        }

        public static Double Radians(Double x)
        {
            const Double PIx = Math.PI;
            return x * PIx / 180;
        }
    }
}
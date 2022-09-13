using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            if (currentColor == TrafficLightColor.Green) {
                return TrafficLightColor.Orange;
            }
            if (currentColor == TrafficLightColor.Orange){
                return TrafficLightColor.Red;
            }
            if(currentColor == TrafficLightColor.Red) {
                return TrafficLightColor.Green;
            }
            return TrafficLightColor.None;
        }
    }
}

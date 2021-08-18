using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalLevel : MonoBehaviour
{
    public static int FireLevel;
    public GameObject FireLevelDisplay;
    public int InternalFireLevel;

    public static int WaterLevel;
    public GameObject WaterLevelDisplay;
    public int InternalWaterLevel;

    public static int AirLevel;
    public GameObject AirLevelDisplay;
    public int InternalAirLevel;

    public static int EarthLevel;
    public GameObject EarthLevelDisplay;
    public int InternalEarthLevel;
    
    void Update() {
        InternalFireLevel = FireLevel;
        InternalWaterLevel = WaterLevel;
        InternalAirLevel = AirLevel;
        InternalEarthLevel = EarthLevel;
        
        FireLevelDisplay.GetComponent<Text>().text = "Fire Level: " + InternalFireLevel;
        WaterLevelDisplay.GetComponent<Text>().text = "Water Level: " + InternalWaterLevel;
        AirLevelDisplay.GetComponent<Text>().text = "Air Level: " + InternalAirLevel;
        EarthLevelDisplay.GetComponent<Text>().text = "Earth Level: " + InternalEarthLevel;
    }
}

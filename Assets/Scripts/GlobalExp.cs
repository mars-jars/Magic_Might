using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalExp : MonoBehaviour
{
    public static int FireExperience;
    public GameObject FireExpDisplay;
    public int InternalFireExp;

    public static int WaterExperience;
    public GameObject WaterExpDisplay;
    public int InternalWaterExp;

    public static int AirExperience;
    public GameObject AirExpDisplay;
    public int InternalAirExp;

    public static int EarthExperience;
    public GameObject EarthExpDisplay;
    public int InternalEarthExp;
    
    void Update() {
        InternalFireExp = FireExperience;
        InternalWaterExp = WaterExperience;
        InternalAirExp = AirExperience;
        InternalEarthExp = EarthExperience;
        
        FireExpDisplay.GetComponent<Text>().text = "Fire Exp: " + InternalFireExp;
        WaterExpDisplay.GetComponent<Text>().text = "Water Exp: " + InternalWaterExp;
        AirExpDisplay.GetComponent<Text>().text = "Air Exp: " + InternalAirExp;
        EarthExpDisplay.GetComponent<Text>().text = "Earth Exp: " + InternalEarthExp;
    }
}

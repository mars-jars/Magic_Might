using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterLevelUp : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject StatusBox;

    public void WaterButtonClick()
    {

        if (GlobalExp.WaterExperience <= 24)
        {
            StatusBox.GetComponent<Text>().text = "Not enough experience. Get 25.";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");

        }
        else
        {
            GlobalExp.WaterExperience -= 25;
            GlobalLevel.WaterLevel += 1;
        }

    }



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirLevelUp : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject StatusBox;

    public void AirButtonClick()
    {

        if (GlobalExp.AirExperience <= 24)
        {
            StatusBox.GetComponent<Text>().text = "Not enough experience. Get 25.";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");

        }
        else
        {
            GlobalExp.AirExperience -= 25;
            GlobalLevel.AirLevel += 1;
        }

    }



}
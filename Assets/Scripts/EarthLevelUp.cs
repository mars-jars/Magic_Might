using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthLevelUp : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject StatusBox;

    public void EarthButtonClick()
    {

        if (GlobalExp.EarthExperience <= 24)
        {
            StatusBox.GetComponent<Text>().text = "Not enough experience. Get 25.";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");

        }
        else
        {
            GlobalExp.EarthExperience -= 25;
            GlobalLevel.EarthLevel += 1;
        }

    }



}
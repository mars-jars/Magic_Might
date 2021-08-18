using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireLevelUp : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject StatusBox;

    public void FireButtonClick()
    {

        if (GlobalExp.FireExperience <= 24)
        {
            StatusBox.GetComponent<Text>().text = "Not enough experience. Get 25.";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");

        }
        else
        {
            GlobalExp.FireExperience -= 25;
            GlobalLevel.FireLevel += 1;
        }
    
    }



}

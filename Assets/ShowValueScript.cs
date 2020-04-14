using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValueScript : MonoBehaviour
{
    public Text percentageText;

    void start()
    {
        percentageText = GetComponent<Text>();
    }
    public void textUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 100) + "";
    }
    public void OnOffSwitch(float value)
    {
        if (value * 100 <= 50) percentageText.text = "Off";
        else percentageText.text = "On";
    }
    public void AutoSave(float value)
    {
        if (value < .1) percentageText.text = "1";
        else if (value >= .1 && value<.2 ) percentageText.text = "2";
        else if (value >= 0.2 && value < .3) percentageText.text = "3";
        else if (value >= .3 && value < .4) percentageText.text = "4";
        else if (value >= .4 && value < .5) percentageText.text = "5";
        else if (value >= .5 && value < .6) percentageText.text = "6";
        else if (value >= .6 && value < .7) percentageText.text = "7";
        else if (value >= .7 && value < .8) percentageText.text = "8";
        else if (value >= .8 && value < .9) percentageText.text = "9";
        else  percentageText.text = "10";
    }

    public void MovementResponse(float value)
    {
        if(value<0.333) percentageText.text = "Standard";
        else if(value>=0.333 && value<=0.666) percentageText.text = "Medium";
        else percentageText.text = "High";
    }


}

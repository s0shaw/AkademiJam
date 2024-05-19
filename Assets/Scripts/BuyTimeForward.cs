using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BuyTimeForward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void BuyTimeForwardButton()
    {
        if (FindObjectOfType<TimePoint>().timePoint >= 250)
        {
            FindObjectOfType<TimePoint>().timePoint -= 250;
            FindObjectOfType<Timer>().characterAge += 10;
            FindObjectOfType<Timer>().UpdateAgeText();
            FindObjectOfType<TimePoint>().UpdateTimePointText();
        }
        else
        {
            Debug.Log("Not enough time points to buy time forward.");
        }
        
    }
}
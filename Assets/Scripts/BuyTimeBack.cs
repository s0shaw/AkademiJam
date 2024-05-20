using Unity.VisualScripting;
using UnityEngine;

public class BuyTimeBack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void BuyTimeBackButton()
    {
        if (FindObjectOfType<TimePoint>().timePoint >= 250)
        {
            FindObjectOfType<TimePoint>().timePoint -= 250;
            FindObjectOfType<Timer>().characterAge -= 10;
            FindObjectOfType<Timer>().UpdateAgeText();
            FindObjectOfType<TimePoint>().UpdateTimePointText();
        }
        else
        {
            Debug.Log("Not enough time points to buy time back");
        }
        
    }
}

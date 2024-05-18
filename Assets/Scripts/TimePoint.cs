using UnityEngine;
using UnityEngine.UI;

public class TimePoint : MonoBehaviour
{
    public int timePoint = 0;
    public Text timePointText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimePointText();
    }

    public void IncreaseTimePoint()
    {
        timePoint++;
        UpdateTimePointText();
    }

    public void UpdateTimePointText()
    {
        timePointText.text = "Time Point: " + timePoint.ToString();
    }
}
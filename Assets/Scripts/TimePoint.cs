using UnityEngine;
using UnityEngine.UI;
using System.Collections;
/*
public class TimePoint : MonoBehaviour
{
    [SerializeField] public int timePoint = 250;
    [SerializeField] public Text timePointText;

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
} */

using UnityEngine;
using UnityEngine.UI;

public class TimePoint : MonoBehaviour
{
    [SerializeField] public int timePoint = 250;
    [SerializeField] public Text timePointText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DecreaseTimePoint());
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

    IEnumerator DecreaseTimePoint()
    {
        while (timePoint > 0)
        {
            yield return new WaitForSeconds(5);
            timePoint -= 50;
            UpdateTimePointText();
        }
    }

    public void UpdateTimePointText()
    {
        timePointText.text = "Time Point: " + timePoint.ToString();
    }
}
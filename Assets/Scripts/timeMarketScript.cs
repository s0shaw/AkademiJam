using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class timeMarket : MonoBehaviour, ITimeMarket
{
    public TimePoint timePointObject; // Reference to the TimePoint object
    public CanvasGroup notEnoughPointsUI; // UI element that appears when there are not enough points
    public float displayDuration = 2.0f; // Duration to display the UI in seconds
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void ShowNotEnoughPointsUI()
    {
        StartCoroutine(ShowAndHideUI());
    }

    private IEnumerator ShowAndHideUI()
    {
        notEnoughPointsUI.alpha = 1; // Show the UI element
        yield return new WaitForSeconds(displayDuration);
        notEnoughPointsUI.alpha = 0; // Hide the UI element after the duration
    }

    public void BuyTimeForward()
    {
        if (timePointObject.timePoint >= 250)
        {
            timePointObject.timePoint -= 250;
            timePointObject.time += 50;
            timePointObject.UpdateTimePointText();
            notEnoughPointsUI.alpha = 0; // Hide the UI element
        }
        else
        {
            ShowNotEnoughPointsUI(); // Show the UI element for a short period of time
        }
    }

    public void BuyTimeBackward()
    {
        // Implement the logic for buying "time backward" here
    }

    public void BuyRandomFeature()
    {
        // Implement the logic for buying "random feature" here
    }
}
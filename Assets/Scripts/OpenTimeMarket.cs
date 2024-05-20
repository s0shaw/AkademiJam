using UnityEngine;
using UnityEngine.UI;

/*
public class OpenTimeMarket : MonoBehaviour
{
    public GameObject[] buttonPrefabs; // Array of button prefabs
    public Transform canvasTransform;
    public bool isMarketOpen = false;

    void Start()
    {


    }

    void Update()
    {
        // Update logic here
    }

    public void OpenMarket()
    {
        for (int i = 0; i < buttonPrefabs.Length; i++) // Loop over the button prefabs
        {
            GameObject button = Instantiate(buttonPrefabs[i], canvasTransform); // Instantiate the i-th button prefab
            button.transform.position = new Vector3(x:450, (i + 1) * 50, 0);
        }

        if (isMarketOpen)
        {
            isMarketOpen = false;
            
        }
        else
        {
            isMarketOpen = true;
        }
        {
            
        }
    }
} */

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class OpenTimeMarket : MonoBehaviour
{
    public GameObject[] buttonPrefabs; // Array of button prefabs
    public Transform canvasTransform;
    public bool isMarketOpen = false;

    private List<GameObject> buttons = new List<GameObject>(); // List to store the instantiated buttons

    void Start()
    {

    }

    void Update()
    {
        // Update logic here
    }

    public void OpenMarket()
    {
        if (isMarketOpen)
        {
            // If the market is open, destroy the buttons and set isMarketOpen to false
            foreach (GameObject button in buttons)
            {
                Destroy(button);
            }
            buttons.Clear();
            isMarketOpen = false;
        }
        else
        {
            // If the market is not open, instantiate the buttons and set isMarketOpen to true
            for (int i = 0; i < buttonPrefabs.Length; i++) // Loop over the button prefabs
            {
                GameObject button = Instantiate(buttonPrefabs[i], canvasTransform); // Instantiate the i-th button prefab
                button.transform.position = new Vector3(x:450, (i + 1) * 50, 0);
                buttons.Add(button);
            }
            isMarketOpen = true;
        }
    }
}
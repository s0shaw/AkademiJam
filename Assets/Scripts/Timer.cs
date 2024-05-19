using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public int characterAge;
    public Text ageText; // Reference to the Text UI element

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(IncreaseAge());
    }

    IEnumerator IncreaseAge()
    {
        while (characterAge < 100)
        {
            yield return new WaitForSeconds(1);
            characterAge++;
            UpdateAgeText();
        }

       
        Debug.Log("Character is dead");
    }

    public void UpdateAgeText()
    {
        ageText.text = "Character Age: " + characterAge.ToString();
    }
}
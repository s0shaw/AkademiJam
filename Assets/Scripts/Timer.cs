using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int characterAge;
    public Text ageText; // Reference to the Text UI element
    public Text situationText; // Reference to the Text UI element for situation message

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(IncreaseAge());
    }

    private void Update()
    {
        if (characterAge < 0)
        {
            situationText.text = "Character has gone.";
            SceneManager.LoadScene("GameOverScene2"); // Load the GameOverScene (end of the game
        }
        else if (characterAge >= 100)
        {
            situationText.text = "Character is dead.";  // Display the message in the UI text element    
            SceneManager.LoadScene("GameOverScene1"); // Load the GameOverScene (end of the game
        }
        else if (characterAge < 13)
        {
            situationText.text = "Character is a child.";
        }
        else if (characterAge < 20)
        {
            situationText.text = "Character is a teenager.";
        }
        else if (characterAge < 60)
        {
            situationText.text = "Character is an adult.";
        }
        else if (characterAge < 100)
        {
            situationText.text = "Character is an elder.";
        }
    }

    IEnumerator IncreaseAge()
    {
        while (characterAge < 100)
        {
            yield return new WaitForSeconds(1);
            characterAge++;
            UpdateAgeText();
        }
    }

    public void UpdateAgeText()
    {
        ageText.text = "Character Age: " + characterAge.ToString();
    }
}
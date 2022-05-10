using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Variables:
    // Integer for score
    private int score;

    // Texts
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI deathText;
    public TextMeshProUGUI winText;



    // Start is called before the first frame update
    void Start()
    {
        // Define the score
        score = 0;
        UpdateScore(0);

        // Disable texts
        deathText.gameObject.SetActive(false);
        winText.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Update the score when given the signal
    public void UpdateScore(int scoreToAdd)
    {
        score = score + scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    // Display game over message when given the signal
    public void GameOver()
    {
        deathText.gameObject.SetActive(true);
    }

    // Display win message when given the signal
    public void Win()
    {
        winText.gameObject.SetActive(true);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    //Variables
    private int score;
    public TextMeshProUGUI scoreText;



    // Start is called before the first frame update
    void Start()
    {
        //Define the score
        score = 0;
        UpdateScore(0);
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
}

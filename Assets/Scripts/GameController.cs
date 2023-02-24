using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int currentScore = 0;
    public Text scoreText;

    void Start()
    {
           currentScore = 0;
    }

    void Update()
    {
    

    }


    void Update_Score_Label()
    {
        scoreText.text = "Score: " + currentScore;
    }


}

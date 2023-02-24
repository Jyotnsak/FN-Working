using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    // Start is called before the first frame update
    void Start()
    {
        Score hs = Score.initialize();
        text1.text = "Score: " + hs.highScoreInt[0];
        text2.text = "Score: " + hs.highScoreInt[1];
        text3.text = "Score: " + hs.highScoreInt[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

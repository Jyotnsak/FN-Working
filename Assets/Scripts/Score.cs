using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Score
{
    private static Score score;
    public int currentScore;
    private Text scoreLabel;
    //array of high scores, indexed by level
    public List<string> highScoreString { get; set; }
    public List<int> highScoreInt { get; set; }
    //private string path = "C:\\Users\\Ninja\\Documents\\Food Ninja\\Assets\\Scripts\\score.txt";

    private Score()
    {
        scoreLabel = GameObject.Find("GameController").GetComponent<GameController>().scoreText;
        currentScore = 0;
        highScoreInt = new List<int>();
        highScoreString = new List<string>();

        //foreach(string line in File.ReadAllLines(path))
        //{
        //    highScoreString.Add(line);
        //    highScoreInt.Add(int.Parse(line));
        //}

        highScoreInt.Add(0);
        highScoreInt.Add(0);
        highScoreInt.Add(0);
    }

    public static Score initialize()
    {
        if (score == null)
        {
            score = new Score();
            score.currentScore = 0;
        }
        return score;
    }

    public static void add_score(int level, int inc)
    {
        if(score == null)
        {
            initialize();
        }
        score.scoreLabel = GameObject.Find("GameController").GetComponent<GameController>().scoreText;
        score.currentScore += inc;
        score.scoreLabel.text = "Score: " + score.currentScore;
        //if (score.currentScore > score.highScoreInt[level])
        //{
        //    score.highScoreInt[level] = score.currentScore;
        //    score.highScoreString[level] = score.currentScore.ToString();
        //    //File.WriteAllLines(score.path, score.highScoreString);
        //}
    }
}

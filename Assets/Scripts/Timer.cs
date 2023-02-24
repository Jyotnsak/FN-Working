using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text startCountdown;
    public float totalCountdownTime;


    void Update()
    {
        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = totalCountdownTime.ToString("F0");
        }
        if (totalCountdownTime <= 0)
        {
            SceneManager.LoadScene(5);
        }

    }


}

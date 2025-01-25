using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float seconds;
    public TextMeshProUGUI TimerText;
    public int minutes = 1;

    void Update()
    {
        TimerText.text = Mathf.RoundToInt(minutes).ToString() + ":" + Mathf.RoundToInt(seconds).ToString();

        seconds -= Time.deltaTime;
        print(minutes);
        print(seconds);

        if (seconds<0)
        {
            if (minutes > 0)
            {
                minutes -= 1;
                seconds += 59;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
        
    }
}

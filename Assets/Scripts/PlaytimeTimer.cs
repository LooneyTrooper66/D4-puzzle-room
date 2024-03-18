using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaytimeTimer : MonoBehaviour
{
    [SerializeField] Text timerText;

    public float timeLeft;


    private void Start()
    {
        timerText = GetComponent<Text>();
    }

    public void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else if (timeLeft <= 0)
        {
            timeLeft = 0;
            SceneManager.LoadScene("GameLost");
        }

        string timerStr = timeLeft.ToString();
        timerText.text = timerStr;
    }
}

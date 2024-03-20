using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaytimeTimer : MonoBehaviour
{
    [SerializeField] Text timerText;

    public float timeLeft;
    public float minutes;
    public float seconds;


    private void Start()
    {
        timerText = GetComponent<Text>();
    }

    public void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            updateTimer(timeLeft);
        }
        else if (timeLeft <= 0)
        {
            timeLeft = 0;
            SceneManager.LoadScene("GameLost");
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime++;

        minutes = Mathf.FloorToInt(currentTime / 60);
        seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}

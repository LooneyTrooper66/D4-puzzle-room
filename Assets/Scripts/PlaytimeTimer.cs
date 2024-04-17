using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaytimeTimer : MonoBehaviour
{
    [SerializeField] Text timerText;

    public float timeLeft;
<<<<<<< Updated upstream
    public string newTime;
    public PauseMenu paused;
=======
>>>>>>> Stashed changes


    private void Start()
    {
        timerText = GetComponent<Text>();
    }

    public void Update()
    {
<<<<<<< Updated upstream
        if (timeLeft > 0 && paused.isPaused == false)
        {
            timeLeft -= Time.deltaTime;
            updateTimer(timeLeft);
=======
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
>>>>>>> Stashed changes
        }
        else if (timeLeft <= 0)
        {
            timeLeft = 0;
            SceneManager.LoadScene("GameLost");
        }
<<<<<<< Updated upstream
    }

    void updateTimer(float currentTime)
    {
        currentTime++;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        newTime = string.Format("{0:00} : {1:00}", minutes, seconds);
        timerText.text = newTime;
=======

        string timerStr = timeLeft.ToString();
        timerText.text = timerStr;
>>>>>>> Stashed changes
    }
}

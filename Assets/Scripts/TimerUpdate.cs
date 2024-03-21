using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUpdate : MonoBehaviour
{
    public Text timerText;
    public PlaytimeTimer playTime;


    private void Start()
    {
        playTime.GetComponent<PlaytimeTimer>();
    }

    private void Update()
    {
        timerText.text = playTime.newTime;
    }
}

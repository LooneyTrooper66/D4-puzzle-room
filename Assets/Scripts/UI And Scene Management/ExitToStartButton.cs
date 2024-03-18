using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToStartButton : MonoBehaviour
{
    public void ExitToStart()
    {
        SceneManager.LoadScene("StartScreen");
    }
}

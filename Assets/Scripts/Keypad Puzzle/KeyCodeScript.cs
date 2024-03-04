using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeScript : MonoBehaviour
{
    public string code = "1234";
    public string num = null;
    private int numIndex = 0;
    public bool codeCorrect;

    public GameObject screenColour;
    public Renderer lightColour;


    private void Start()
    {
        lightColour = screenColour.GetComponent<Renderer>();
        codeCorrect = false;
    }

    public void Passcode(string numbers)
    {
        if (codeCorrect == false)
        {
            numIndex++;
            num = num + numbers;
            Correct();
        }
    }

    public void Correct()
    {
        if (num == code)
        {
            RedLight();
        }
        else if (num != code && num.Length >= 4)
        {
            num = null;
            lightColour.material.SetColor("_EmissionColor", Color.yellow);
            Invoke("YellowLight", 1);
        }
    }

    void RedLight()
    {
        lightColour.material.SetColor("_EmissionColor", Color.red);
        codeCorrect = true;
    }

    void YellowLight()
    {
        lightColour.material.SetColor("_EmissionColor", Color.green);
    }
}

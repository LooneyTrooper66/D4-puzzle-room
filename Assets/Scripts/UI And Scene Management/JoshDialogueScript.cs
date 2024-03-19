using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoshDialogueScript : MonoBehaviour
{
    public BreakerBoxPuzzle breakerScr;
    private bool completeBr;
    public DoubleDoorsScript doorsScr;
    private bool completeDr;
    public PickUpScript paperScr;
    private bool completePa;
    public KeyCodeScript keycodeScr;
    private bool completeKc;
    public KeycodePuzzleRaycastScript buttonScr;
    private bool completeBu;

    public Text joshText;
    private float textTimer = 8;
    public string[] dialogue;
    private int i = 0;
    private bool first;


    void Start()
    {
        first = true;
        completeBr = false;
        completeDr = false;
        completePa = false;
        completeKc = false;
        completeBu = false;
    }

    void Update()
    {
        if (first == true)
        {
            InitialDialogue();
        }

        if (breakerScr.wiresConnected == true)
        {
            if (completeBr == false)
            {
                Wires();
            }
        }

        if (doorsScr.woodPlaced == true)
        {
            if (completeDr == false)
            {
                Planks();
            }
        }

        if (paperScr.paperUp == true)
        {
            if (completePa == false)
            {
                Paper();
            }
        }

        if (keycodeScr.codeCorrect == true)
        {
            if (completeKc == false)
            {
                Code();
            }
        }

        if (buttonScr.buttonOn == true)
        {
            if (completeBu == false)
            {
                Button();
            }
        }
    }

    void InitialDialogue()
    {
        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else if (textTimer <= 0)
        {
            if (i <= 2)
            {
                joshText.text = dialogue[i];
                i++;
                textTimer = 8;
            }
            else if (i >= 3 || completeBr == true)
            {
                joshText.text = " ";
                first = false;
            }
        }
    }

    void Wires()
    {
        textTimer = 5;
        joshText.text = "Alright nice! \nWait.. I can hear the undead outside, they’re getting close. \nUse those broken bits of wood to block the doors, quick!";

        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else if (textTimer <= 0 || completeDr == true)
        {
            textTimer = 0;
            joshText.text = " ";
        }
        completeBr = true;
    }

    void Planks()
    {
        textTimer = 8;
        joshText.text = "Nice! It'll be difficult for them to get in now, but those noises are still too close for comfort.\nThat door only locks if you put in a combination code. Quick, look around. We need to find that code.";

        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else if (textTimer <= 0 || completePa == false)
        {
            Debug.Log("called");
            textTimer = 0;
            Hint();
        }
        else if (textTimer <= 0 || completePa == true)
        {
            Debug.Log("not called");
            textTimer = 0;
            joshText.text = " ";
        }
        completeDr = true;
    }

    void Hint()
    {
        textTimer = 6;
        joshText.text = " ";

        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else if (textTimer <= 0 && completePa == false)
        {
            textTimer = 0;
            joshText.text = "Maybe check behind the counter, i bet the owner would keep it there.";
        }
    }

    void Paper()
    {
        textTimer = 6;
        joshText.text = "Wow, so secure. Just go key it in, the numpad is next to the door. \nI've heard those keys can be a bit sticky, so just keep trying.";

        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else if (textTimer <= 0 || completeKc == true)
        {
            textTimer = 0;
            joshText.text = " ";
        }
        completePa = true;
    }

    void Code()
    {
        textTimer = 10;
        joshText.text = "Jesus, that felt close.\nOk, when the virus first came about, the military converted anything they could into civilian controlled defence systems. There was a pinball machine in this bar, I'm sure they made that into one too. Look around, there should be a switch to activate it somewhere.";

        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else if (textTimer <= 0 || completeBu == true)
        {
            textTimer = 0;
            joshText.text = "  ";
        }
        completeKc = true;
    }

    void Button()
    {
        textTimer = 10;
        joshText.text = "There it is! Now quick, play it and beat it, it’ll launch weapons to kill the undead within guildford. With this, we may be able to protect everyone else until reinforcements arrive! Just keep an eye on the time, coz we’re running out of it.";

        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else if (textTimer <= 0)
        {
            textTimer = 0;
            joshText.text = " ";
        } 
        completeBu = true;
    }
}

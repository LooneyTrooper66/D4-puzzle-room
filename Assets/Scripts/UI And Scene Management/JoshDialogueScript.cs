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
    private bool hintPlayed;
    public PickUpScript paperScr;
    private bool completePa;
    public KeyCodeScript keycodeScr;
    private bool completeKc;
    public KeycodePuzzleRaycastScript buttonScr;
    private bool completeBu;

    public Text joshText;


    private void Start()
    {
        completeBr = false;
        completeDr = false;
        hintPlayed = false;
        completePa = false;
        completeKc = false;
        completeBu = false;

        StartCoroutine(FirstLine());
    }

    private void Update()
    {
        if (breakerScr.wiresConnected == true)
        {
            if (completeBr == false)
            {
                StartCoroutine(WiresDone());
            }
        }

        if (doorsScr.woodPlaced == true)
        {
            if (completeDr == false)
            {
                StartCoroutine(PlanksDone());
            }
            else if (completeDr == true && hintPlayed == false)
            {
                StartCoroutine(Hint());
            }
        }

        if (paperScr.paperUp == true)
        {
            if (completePa == false)
            {
                StartCoroutine(PaperUp());
            }
        }

        if (keycodeScr.codeCorrect == true)
        {
            if (completeKc == false)
            {
                StartCoroutine(KeycodeDone());
            }
        }

        if (buttonScr.buttonOn == true)
        {
            if (completeBu == false)
            {
                StartCoroutine(PinballOn());
            }
        }

    }

    IEnumerator ClearText()
    {
        joshText.text = string.Empty;
        yield return null;
    }

    IEnumerator FirstLine()
    {
        joshText.text = "Thank fuck, we got away.\nAh , shit this hurts. I'm not going to be able to walk for a while, but I'll instruct you on what to do.";
        yield return new WaitForSeconds(6f);
        StartCoroutine(SecondLine());
    }

    IEnumerator SecondLine()
    {
        joshText.text = "Luckily we weren't followed. We only need to hold out here for around 5 minutes,\nThe reinforcements will be on their way soon.";
        yield return new WaitForSeconds(5f);
        if (breakerScr.wiresConnected == false)
        {
            StartCoroutine(ThirdLine());
        }
    }

    IEnumerator ThirdLine()
    {
        joshText.text = "This place used to be a vr arcade.. Before the virus… it must have backup\n power somewhere. Find the circuit box, you'll probably be able to turn it on.";
        yield return new WaitForSeconds(5f);
        StartCoroutine(ClearText());
    }

    IEnumerator WiresDone()
    {
        joshText.text = "Alright nice! \nWait.. I can hear the undead outside, they’re getting close. \nUse those broken bits of wood to block the doors, quick!";
        yield return new WaitForSeconds(5f);
        completeBr = true;
        StartCoroutine(ClearText());
    }

    IEnumerator PlanksDone()
    {
        completeBr = true;
        joshText.text = "Nice! It'll be difficult for them to get in now, but those noises are still too close for comfort.\nThat door only locks if you put in a combination code. Quick, look around. We need to find that code.";
        yield return new WaitForSeconds(6f);
        completeDr = true;
    }

    IEnumerator Hint()
    {
        completeDr = true;
        joshText.text = string.Empty;
        yield return new WaitForSeconds(5f);
        if (hintPlayed == false)
        {
            joshText.text = "Maybe check behind the counter, i bet the owner would keep it there.";
            yield return new WaitForSeconds(3f);
            hintPlayed = true;
            StartCoroutine(ClearText());
        }
    }

    IEnumerator PaperUp()
    {
        hintPlayed = true;
        joshText.text = "Wow, so secure. Just go key it in, the numpad is next to the door. \nI've heard those keys can be a bit sticky, so just keep trying.";
        yield return new WaitForSeconds(5f);
        completePa = true;
        StartCoroutine(ClearText());
    }

    IEnumerator KeycodeDone()
    {
        completePa = true;
        joshText.text = "Jesus, that felt close.\nOk, when the virus first came about, the military converted anything they could into civilian controlled defence systems.";
        yield return new WaitForSeconds(4f);
        StartCoroutine(KeyDone2());
    }

    IEnumerator KeyDone2()
    {
        joshText.text = "There was a pinball machine in this bar, I'm sure they made that into one too. Look around, there should be a switch to activate it somewhere.";
        yield return new WaitForSeconds(4f);
        completeKc = true;
        StartCoroutine(ClearText());
    }

    IEnumerator PinballOn()
    {
        completeKc = true;
        joshText.text = "There it is! Now quick, play it and beat it, it’ll launch weapons to kill the undead within guildford.";
        yield return new WaitForSeconds(3f);
        StartCoroutine(PinballOn2());
    }

    IEnumerator PinballOn2()
    {
        joshText.text = "With this, we may be able to protect everyone else until reinforcements arrive! Just keep an eye on the time, coz we’re running out of it.";
        yield return new WaitForSeconds(4f);
        completeBu = true;
        StartCoroutine(ClearText());
    }
}

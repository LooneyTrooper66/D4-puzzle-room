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
<<<<<<< Updated upstream
    private bool hintPlayed;
=======
>>>>>>> Stashed changes
    public PickUpScript paperScr;
    private bool completePa;
    public KeyCodeScript keycodeScr;
    private bool completeKc;
    public KeycodePuzzleRaycastScript buttonScr;
    private bool completeBu;

<<<<<<< Updated upstream
    private bool stopped;
    private bool stopped1;
    private bool stopped2;

    public Text joshText;

    public PauseMenu paused;


    private void Start()
    {
        completeBr = false;
        completeDr = false;
        hintPlayed = false;
        completePa = false;
        completeKc = false;
        completeBu = false;
        stopped = false;
        stopped1 = false;
        stopped2 = false;

        StartCoroutine(FirstLine());
    }

    private void Update()
    {
        // plays text after wires completed \\
=======
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

>>>>>>> Stashed changes
        if (breakerScr.wiresConnected == true)
        {
            if (completeBr == false)
            {
<<<<<<< Updated upstream
                StartCoroutine(WiresDone());
            }
        }

        // plays text after wood puzzle completed \\
        if (doorsScr.woodPlaced == true)
        {
            completeBr = true;
            if (completeDr == false)
            {
                StopForPlank();
                StartCoroutine(PlanksDone());
            }
            else if (completeDr == true && hintPlayed == false)
            {
                // plays hint if not found paper after 6 seconds \\
                StartCoroutine(Hint());
                hintPlayed = true;
            }
        }

        // plays text after paper picked up \\
        if (paperScr.paperUp == true)
        {
            hintPlayed = true;
            if (completePa == false)
            {
                StartCoroutine(PaperUp());
            }
        }

        // plays text after keycode inputted correctly \\
        if (keycodeScr.codeCorrect == true)
        {
            hintPlayed = true;
            completePa = true;
            if (completeKc == false)
            {
                StopForCode();
                StartCoroutine(KeycodeDone());
            }
        }

        // plays text after button pressed \\
        if (buttonScr.buttonOn == true)
        {
            completeKc = true;
            if (completeBu == false)
            {
                StopForButton();
                StartCoroutine(PinballOn());
            }
        }

    }

    void StopForPlank()
    {
        if (stopped1 == false)
        {
            StopAllCoroutines();
            stopped1 = true;
        }
    }

    void StopForCode()
    {
        if (stopped2 == false)
        {
            StopAllCoroutines();
            stopped2 = true;
        }
    }

    void StopForButton()
    {
        if (stopped == false)
        {
            StopAllCoroutines();
            stopped = true;
        }
    }

    IEnumerator FirstLine()
    {
        joshText.text = "Thank god, we got away.\nAh , shit this hurts. I'm not going to be able to walk for a while, but I'll instruct you on what to do.";
        yield return new WaitForSeconds(6f);
        if (breakerScr.wiresConnected == false)
        {
            StartCoroutine(SecondLine());
        }
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
        joshText.text = string.Empty;
    }

    IEnumerator WiresDone()
    {
        joshText.text = "Alright nice! \nWait.. I can hear the undead outside, they’re getting close. \nUse those broken bits of wood to board up both doors, quick!";
        yield return new WaitForSeconds(5f);
        completeBr = true;
        joshText.text = string.Empty;
    }

    IEnumerator PlanksDone()
    {
        joshText.text = "Nice! It'll be difficult for them to get in now, but those noises are still too close for comfort.\nThat door only locks if you put in a combination code. Quick, look around. We need to find that code.";
        yield return new WaitForSeconds(6f);
        completeDr = true;
    }

    IEnumerator Hint()
    {
        joshText.text = string.Empty;
        yield return new WaitForSeconds(5f);
        joshText.text = "Maybe check behind the counter, i bet the owner would keep it there.";
        yield return new WaitForSeconds(3f);
        hintPlayed = true;
        joshText.text = string.Empty;
    }

    IEnumerator PaperUp()
    {
        joshText.text = "Wow, so secure. Just go key it in, the numpad is next to the door. \nI've heard those keys can be a bit sticky, so just keep trying.";
        yield return new WaitForSeconds(5f);
        completePa = true;
        joshText.text = string.Empty;
    }

    IEnumerator KeycodeDone()
    {
        joshText.text = "Jesus, that felt close.\nOk, when the virus first came about, the military converted anything they could into civilian controlled defence systems.";
        yield return new WaitForSeconds(4f);
        completeKc = true;
        StartCoroutine(KeyDone2());
    }

    IEnumerator KeyDone2()
    {
        completePa = true;
        joshText.text = "There was a pinball machine in this bar, I'm sure they made that into one too. Look around, there should be a switch to activate it somewhere.";
        yield return new WaitForSeconds(4f);
        joshText.text = string.Empty;
    }

    IEnumerator PinballOn()
    {
        joshText.text = "There it is! Now quick, play it and beat it, it’ll launch weapons to kill the undead within guildford.";
        yield return new WaitForSeconds(4f);
        completeBu = true;
        StartCoroutine(PinballOn2());
    }

    IEnumerator PinballOn2()
    {
        completeKc = true;
        joshText.text = "With this, we may be able to protect everyone else until reinforcements arrive! Just keep an eye on the time, coz we’re running out of it.";
        yield return new WaitForSeconds(5f);
        joshText.text = string.Empty;
=======
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
        else if (textTimer <= 0 || completeBr == true)
        {
            if (i <= 2)
            {
                joshText.text = dialogue[i];
                i++;
                textTimer = 8;
            }
            else if (i >= 3)
            {
                joshText.text = dialogue[2];
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
        else if (textTimer <= 0 || completePa == true)
        {
            textTimer = 0;
            joshText.text = " ";
        }
        completeDr = true;
    }

    void Hint()
    {
        textTimer = 8;
        if (textTimer > 0)
        {
            textTimer -= Time.deltaTime;
        }
        else if (textTimer <= 0 || completeDr == true || completePa == true)
        {
            if (paperScr.paperUp == false)
            {
                textTimer = 0;
                joshText.text = "Maybe check behind the counter, i bet the owner would keep it there.";
            }
            else
            {
                textTimer = 0;
            }
        }
        completeDr = true;
    }

    void Paper()
    {
        textTimer = 10;
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
            joshText.text = " ";
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
>>>>>>> Stashed changes
    }
}

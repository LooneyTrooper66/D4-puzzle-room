using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinColliderScript : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
<<<<<<< Updated upstream
            Destroy(collision.gameObject);
            BallSpawnScript.loadIndex = BallSpawnScript.loadIndex - 1;
=======
>>>>>>> Stashed changes
            SceneManager.LoadScene("GameWon");
        }
    }
}

using UnityEngine;

public class LooseColliderScript : MonoBehaviour
{
    public BallSpawnScript ballSpawn;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Destroy(collision.gameObject);
            BallSpawnScript.loadIndex = BallSpawnScript.loadIndex - 1;
        }
    }
}
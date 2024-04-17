using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTVs : MonoBehaviour
{
    public AK.Wwise.Event TV_ON;
    public CircuitBoxCamera box;


    // Start is called before the first frame update
    void Start()
    {
       box = GetComponent<CircuitBoxCamera>();    
    }

    // Update is called once per frame
    void Update()
    {
        box.GetComponent<CircuitBoxCamera>().TVisON().TVON();
        
        if ()
        {
            TV_ON.Post(gameObject);
        }
    }
}

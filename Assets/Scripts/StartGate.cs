using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGate : MonoBehaviour
{
    void OnTriggerEnter(Collider o) {
        if (o.tag == "Player") {
            // start the timer
            Debug.Log("Timer Started." + o.tag);
            GateManager.StartTimer();
        }
    }

}

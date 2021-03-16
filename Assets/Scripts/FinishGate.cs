using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGate : MonoBehaviour
{

    void OnTriggerEnter(Collider o) {
        if (o.tag == "Player") {
            // start the timer
            Debug.Log("Timer Stopped." + o.tag);
            GateManager.StopTimer();
        }
    }
}

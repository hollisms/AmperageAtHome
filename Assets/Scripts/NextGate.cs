using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextGate : MonoBehaviour
{
    void OnTriggerEnter(Collider o) {
        Debug.Log("Tag that hit gate: " + o.tag);
        if (o.tag == "Player") {

            // destroy the gate
            Destroy(gameObject);
            GateManager.NextGate();
        }
    }
}

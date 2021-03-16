using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTimer : MonoBehaviour
{
    private Text txtTimer;

    void Start() {
        txtTimer = GameObject.Find("txtTimer").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float time = GateManager.GetElapsedTime();
        txtTimer.text = time.ToString("F2");
    }
}

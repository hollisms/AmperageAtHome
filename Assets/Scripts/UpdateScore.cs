using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    private Text txtScore;
    private Text txtConeCounter;
    private Text txtTimer;

    void Start() {
        txtScore = GameObject.Find("txtScore").GetComponent<Text>();
        txtTimer = GameObject.Find("txtTimer").GetComponent<Text>();
        txtConeCounter = GameObject.Find("txtConeCounter").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        // Score equals the time + (5 * number of cones hit)
        float score = float.Parse(txtConeCounter.text);
        score *= 5;
        score += float.Parse(txtTimer.text);
        txtScore.text = score.ToString("F2");
        
    }
}

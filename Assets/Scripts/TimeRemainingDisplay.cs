using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemainingDisplay : MonoBehaviour {

    Text text;
    LevelManager remainingTime;

    // Use this for initialization
    void Start()
    {
        remainingTime = FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Time: " + remainingTime.timeTillEnd.ToString("F2");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

    Text text;
    ScoreAbsorber score;

    // Use this for initialization
    void Start()
    {
        score = FindObjectOfType<ScoreAbsorber>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score != null)
            text.text = "Score: " + score.score;
    }
}

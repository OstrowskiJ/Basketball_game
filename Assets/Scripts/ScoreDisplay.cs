using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
	Text text;
	ScoreKeep score;

	// Use this for initialization
	void Start ()
	{
		score = FindObjectOfType<ScoreKeep>();
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		text.text = "Score: " + score.score;
	}
}

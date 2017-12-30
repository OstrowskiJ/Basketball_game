using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeep : MonoBehaviour
{
	public int score;

	// Use this for initialization
	void Start ()
	 {
		 DontDestroyOnLoad(this.gameObject);
	 }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision colission)
	{
		score++;
		print("Ball hitted, your score:" + score);
	}
}

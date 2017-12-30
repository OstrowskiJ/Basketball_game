using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour
{


	public int score = 0;

	// Use this for initialization
	void Start ()
	{
		ScoreKeep oldKeep = FindObjectOfType<ScoreKeep>();
	    if (oldKeep)
	    {
	        score = oldKeep.score;
	        Destroy(oldKeep.gameObject);
	    }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

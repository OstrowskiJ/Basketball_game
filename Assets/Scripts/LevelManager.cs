using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public float timeTillEnd = 0;

	// Use this for initialization
	void Start ()
	{
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	// Update is called once per frame
	void Update () {

		if (timeTillEnd > 0)
		{
			timeTillEnd -= Time.deltaTime;
			if (timeTillEnd < 0)
			{
				LoadNextScene();
			}
		}
	}

	public void LoadNextScene()
	{
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex + 1);
	}

	public void LoadPreviousLevel()
	{
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex - 1);
	}

	public void IncrementTime()
	{
		timeTillEnd += 1;
	}
}

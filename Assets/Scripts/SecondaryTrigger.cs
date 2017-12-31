using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour
{
    Collider expectedCollider;

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedCollider)
        {
            ScoreKeep scoreKeep = FindObjectOfType<ScoreKeep>();
            LevelManager lvlManager = FindObjectOfType<LevelManager>();
            scoreKeep.IncrementScore(1);
            lvlManager.IncrementTime();
            
        }

    }

}

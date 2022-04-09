using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    void OnCollisionEnter(Collision otherObject)
    {
       
        if(otherObject.gameObject.tag != "Hit")
        {
            score ++;
            Debug.Log("You have bumped into a thing these many times: " + score);
            otherObject.gameObject.tag = "Hit";
        }

    }
}

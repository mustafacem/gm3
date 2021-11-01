using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Score : MonoBehaviour
{
    public GameObject scoreScript;
    // Use this for initialization
    public void OnCollisionEnter(Collision col)
    {
       
            ScoreMenager scorePointsScript = scoreScript.GetComponent<ScoreMenager>();
            scorePointsScript.AddScore();
        
    }
}
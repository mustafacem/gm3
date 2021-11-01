using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class ScoreMenager : MonoBehaviour
{
    public int points;
    Text text;
    void Awake()
    {
        text = GetComponent<Text>();
    }
    // Use this for initialization
    void Start()
    {
    }
    public void AddScore()
    {
        points++;
    }
    // Update is called once per frame
    void Update()
    {

        text.text = "Score: " + points;
    }
}
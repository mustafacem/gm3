using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yok_ulayan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var randomInt = Random.Range(4f, 7f);
      //  Debug.Log(randomInt);
        Destroy(gameObject, randomInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

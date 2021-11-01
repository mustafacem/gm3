using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeni : MonoBehaviour
{
    public float ileri = 10;
    public float donme = 60;
 

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * donme * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * ileri * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }

    void FixedUpdate()
    {
   //     transform.Translate(Camera.main.transform.forward * thrust * Time.deltaTime);
    }
}
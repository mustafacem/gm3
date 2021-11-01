using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_yay : MonoBehaviour
{
    public Camera kamera;
    public GameObject Ok;
    public Transform ok_cıkıs/*senin eski emitter*/;
    public float ok_hızı;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            GameObject go = Instantiate(Ok, ok_cıkıs.position, Quaternion.identity);
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.velocity = kamera.transform.forward * ok_hızı; 
        }
        
    }
}

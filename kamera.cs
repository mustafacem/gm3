using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{


    public float hasaslık = 10;
    public Transform odak;
    public float mesafe=2;
    public Vector2 pitchminmax=new  Vector2(-40,85);
    //public Vector2 yawminmax = new Vector2(-40, 85);

    public float donmezmanı = .1f;
    Vector3 donmeivme;
    Vector3 suankihal;

    float yaw;
    float pitch;
    
    // Update is called once per frame
    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * hasaslık;
        pitch -= Input.GetAxis("Mouse Y") * hasaslık;
        pitch = Mathf.Clamp(pitch,pitchminmax.x,pitchminmax.y); //limitliyo

        suankihal = Vector3.SmoothDamp(suankihal, new Vector3(pitch, yaw), ref donmeivme, donmezmanı);

      //  Vector3 targetRotation = new Vector3(pitch, yaw);
        transform.eulerAngles = suankihal;

        transform.position = odak.position - transform.forward * mesafe;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ofyan : MonoBehaviour
{


    public bool x;
    public ParticleSystem ates;


    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("a"))
        {
            Debug.Log("vurdu abi");

            x = true;
            //Destroy(col.gameObject);

            if (!x)
            {

                ates.Play();
            }

        }
        else if (x)
        {

            ates.Stop();

            //dust.Pause();
            //dust.Clear();
        }
    }



}

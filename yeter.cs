using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeter : MonoBehaviour
{

    public GameObject myParticles;

    void Start()
    {
        myParticles.SetActive(false);
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("a"))
        {
            Debug.Log("vurdulduk");
            myParticles.SetActive(true);
            skorsis.skorK -= 4;
            //Destroy(col.gameObject);
        }
    }



    /*
    void Update()
    {
        if (col.collider.CompareTag("a"))
        {


        }
            
            if (Input.GetKeyDown("h") && myParticles.activeSelf == false)
            {
                myParticles.SetActive(true);
            }
            else if (Input.GetKeyDown("h") && myParticles.activeSelf == true)
            {
                myParticles.SetActive(false);
            }
          */

}
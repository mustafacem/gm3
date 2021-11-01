using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_oyuncu : MonoBehaviour {
    //public float zıp_guc;
    [Header("gorsel")]
    public GameObject modeller;
    public float donme_hız;

    [Header("hareket")]

    public float zıp_surat;
    public float hareket_surat;

    [Header("ekipman")]
    public  scr_kılıc kılıc;//once genel  scriptte spnra ozel lismiş 


    private bool zıp_izin;
    private Rigidbody oyuncu_rigidbody;
    private Quaternion model_yon;
	// Use this for initialization
	void Start () {
        oyuncu_rigidbody = GetComponent<Rigidbody>();
        model_yon = Quaternion.Euler(0, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {
      
        RaycastHit vurdu;
        if (Physics.Raycast(transform.position, Vector3.down, out vurdu, 1.01f))//altan bir şeyye ışın değiyorsa
        {
            zıp_izin = true;

        }
       // modeller.transform.rotation = Quaternion.Lerp(modeller.transform.rotation, model_yon, Time.deltaTime * donme_hız);

       ProcessInput();
    }


    void ProcessInput()
    {


        oyuncu_rigidbody.velocity = new Vector3(
                0,
                 oyuncu_rigidbody.velocity.y,
                0);
       
        if (zıp_izin == true && Input.GetKeyDown("space"))
        {
            zıp_izin = false;
            // GetComponent<Rigidbody>().AddForce(0, zıp_guc, 0);
            oyuncu_rigidbody.velocity = new Vector3(oyuncu_rigidbody.velocity.x, zıp_surat, oyuncu_rigidbody.velocity.z);
        }

        if (Input.GetMouseButtonDown(0))
        {
           kılıc.Saldırı();
        }

    }


}

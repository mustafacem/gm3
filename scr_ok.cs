using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ok : MonoBehaviour
{
    Rigidbody ok_kendisi;
    private float lifeTimer = 2f;
    private float timer;
    private bool vurdumu= false;

    // Start is called before the first frame update
    private void Start()
    {
        ok_kendisi= GetComponent<Rigidbody>();
        transform.rotation = Quaternion.LookRotation(ok_kendisi.velocity);
    }

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeTimer)
        {
            Destroy(gameObject);
        }

        if (!vurdumu)
        {
            transform.rotation = Quaternion.LookRotation(ok_kendisi.velocity);
        }

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "ok")
        {
            vurdumu = true;
            yapıs();
        }
    }

    private void yapıs()
    {
        ok_kendisi.constraints = RigidbodyConstraints.FreezeAll;
    }

}

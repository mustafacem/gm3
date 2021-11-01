using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_devam : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool durdu = false;
    public GameObject ara_yuz_esc;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 

            if (durdu) 
        {
            devam();
        }
        else
        {
            durdur();
        }
      }
    }
    public void devam()
    {
        ara_yuz_esc.SetActive(false);
        Time.timeScale = 1F;
        durdu = false;
    }

    void durdur()
    {
        ara_yuz_esc.SetActive(true);
        Time.timeScale = 0F;
        durdu = true;
    }
    public void oyundan_cık()
    {
        Application.Quit();
        Debug.Log("ben ssut almya gidiyeyrum");
    }
}

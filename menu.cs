using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{

    // Use this for initialization
    public void abazan()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void mat()
    {
        SceneManager.LoadScene(2);
    }


    public void fen()
    {
        SceneManager.LoadScene(3);
    }

    public void cıkıs()
    {
        Application.Quit();
        Debug.Log("ben ssut almya gidiyeyrum");
    }
    public void geri()
    {
        SceneManager.LoadScene(0);
    }
    public void mat_lvl_1()
    {
        SceneManager.LoadScene(1);
    }
    public void fen_lvl_1()
    {
        SceneManager.LoadScene(4);
    }
   

}

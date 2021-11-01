using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_kılıc : MonoBehaviour {

    public float savurma_hızı = 2f;
    public float soguma_hızı = 2f;
    public float soguma_suresi = 0.5f;
    public float saldırı_suresi = 0.35f;

    private Quaternion hedef_pozisyon;
    private float sogma_alarmı;
    private bool saldırıyor;
	// Use this for initialization
	void Start () {
        hedef_pozisyon = Quaternion.Euler(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {

        transform.localRotation = Quaternion.Lerp(transform.localRotation, hedef_pozisyon, Time.deltaTime * (saldırıyor ? savurma_hızı : soguma_hızı ));//local olunca asıl obje(oyuncu )rotasyonu değişse bile sıfır kaliyor //saldırıyor kompkat if işste anala

        sogma_alarmı -= Time.deltaTime;

    }

    public void Saldırı()
    {
        if (sogma_alarmı>0f)
        {
            return; 
        }
        hedef_pozisyon = Quaternion.Euler(-90, 0, 0);

        sogma_alarmı = soguma_suresi;
        StartCoroutine(Bekleme_soguma());
    }
   private IEnumerator Bekleme_soguma()//bekleme için alarımın parçası
    {
        saldırıyor = true;
       yield return new WaitForSeconds(saldırı_suresi);
        saldırıyor = false;
       hedef_pozisyon = Quaternion.Euler(0, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
      //  GameObject.addfor(, transform.position, transform.rotation);

      //  Destroy(gameObject);
    }

}

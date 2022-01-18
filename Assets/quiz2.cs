using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz2 : MonoBehaviour
{
  
    public GameObject uiObject;
    public GameObject teleport;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;

    void Start()
    {
        uiObject.SetActive(false);
        enemy1.SetActive(false);
        enemy2.SetActive(false);
        enemy3.SetActive(false);
        enemy4.SetActive(false);
        enemy5.SetActive(false);
        enemy6.SetActive(false);
        teleport.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);


            //StartCoroutine("WaitForSec");
        }

    
 

   

    }

}

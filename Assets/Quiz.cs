using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public Text mytext;
    int count = 0;
    public GameObject uiObject;
    public GameObject uiObject1;
    public GameObject uiObject2;
    public GameObject uiObject3;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
      
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);


            //StartCoroutine("WaitForSec");
        }

        //question 1 
       


        //question 2


    }



}

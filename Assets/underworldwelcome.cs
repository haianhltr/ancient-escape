using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underworldwelcome : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {


        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);

            Destroy(uiObject, 3);
            //StartCoroutine("WaitForSec");
        }




    }
}

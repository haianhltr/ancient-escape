using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underworldtrap : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject1;
    public Animator myanimation1;
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

      
      

    }


}

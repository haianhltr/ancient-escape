using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidunder : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
      
            uiObject.SetActive(true);

            Destroy(uiObject, 3);
            //StartCoroutine("WaitForSec");
        

    }
}

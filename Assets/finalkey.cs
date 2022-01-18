using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalkey : MonoBehaviour
{
  

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {

        GameVariables.finalkey1 += 1;
        Destroy(gameObject);
    }

}

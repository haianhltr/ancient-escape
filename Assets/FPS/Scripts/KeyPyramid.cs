using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPyramid : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {

        GameVariables.keyPyramid += 1;
        Destroy(gameObject);
    }

}

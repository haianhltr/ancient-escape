using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1stPyramid : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (GameVariables.keyPyramid == 3)
        {
            GameVariables.keyPyramid =0;
           
            Destroy(gameObject);
        }
    }
}

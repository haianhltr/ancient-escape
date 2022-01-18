using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySecPy : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {

        GameVariables.keySecondFloorPy += 1;
        Destroy(gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSecPy : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (GameVariables.keySecondFloorPy == 0)
        {
            GameVariables.keySecondFloorPy = 0;

            Destroy(gameObject);
        }
    }
}

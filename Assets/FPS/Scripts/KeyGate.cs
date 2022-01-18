using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (GameVariables.key > 0)
        {
            GameVariables.key--;
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider) {

        GameVariables.key += 2;
        Destroy(gameObject);
    }
}

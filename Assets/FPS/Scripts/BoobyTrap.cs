using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoobyTrap : MonoBehaviour
{
    public GameObject seconddoor;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {

        Destroy(gameObject);
        Destroy(seconddoor);
    }
}

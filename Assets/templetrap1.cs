using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class templetrap1 : MonoBehaviour
{
    public GameObject templetrap;
    // Start is called before the first frame update
    void Start()
    {
        templetrap.SetActive(false);
    }
    void OnTriggerEnter(Collider collider)
    {
        templetrap.SetActive(true);
    }
}

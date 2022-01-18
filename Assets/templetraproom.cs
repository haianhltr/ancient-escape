using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class templetraproom : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    void Start()
    {
        enemy1.SetActive(false);
        enemy2.SetActive(false);
        enemy3.SetActive(false);
        enemy4.SetActive(false);
    }

    void OnTriggerEnter(Collider collider)
    {
        enemy4.SetActive(true);
        enemy2.SetActive(true);
        enemy3.SetActive(true);
        enemy1.SetActive(true);

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finaldoor : MonoBehaviour
{
    public GameObject TheWall;

    void Start()
    {
        TheWall.SetActive(false);
      

    }

    void OnTriggerEnter(Collider collider)
    {
        if (GameVariables.finalkey1 == 3)
        {
            GameVariables.finalkey1 = 0;

            Destroy(gameObject);
        }
        else {
            TheWall.SetActive(true);
            Destroy(TheWall,4);
        }
    }
}

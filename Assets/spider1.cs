using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider1 : MonoBehaviour
{
    public GameObject teleportgate8;
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        GameVariables.question1 = 2;

        Destroy(teleportgate8);
    }


}

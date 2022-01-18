using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heaventohell : MonoBehaviour
{

    public Transform teleportTarget;
    public GameObject player;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
    }

}

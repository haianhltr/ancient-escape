using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject teleportTarget;
    public GameObject player;
    public GameObject heaventohell;
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
        Destroy(heaventohell);
    }
}

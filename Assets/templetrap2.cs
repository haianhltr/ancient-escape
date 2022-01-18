using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class templetrap2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform teleportTarget;
    public GameObject player;
    public GameObject fakekey;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider collider)
    {
        player.transform.position = teleportTarget.transform.position;
        Destroy(fakekey);
    }
}

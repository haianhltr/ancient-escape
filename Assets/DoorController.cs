using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public GameObject Door;
    public bool doorisOpening;


   

    // Update is called once per frame
    void Update()
    {
      if(doorisOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
            //if the bool is true open door


        }
        if (Door.transform.position.y > 7f)
        {
            doorisOpening = false;
        }
    }

    void OnMouseDown()
    {
        doorisOpening = true;
    }



}

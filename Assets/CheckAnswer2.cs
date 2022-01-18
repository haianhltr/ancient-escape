using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer2 : MonoBehaviour
{
    public Text mytext;
    public Text mytext2;
    int count = 0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject TheWall;
    
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        if (count == 0)
        {
            if (GameVariables.question1 == 2)
            {
                Destroy(enemy1);
                mytext.text = "CORRECT,The world's largest pyramid is the great pyramid of Cholula in Mexico\nThey invented toothpaste!.";
               
                GameVariables.question1 = 0;
           
              
                count++;
            }
            if (GameVariables.question1 == 1)
            {
            
                mytext.text = "INCORRECT,The world's largest pyramid is the great pyramid of Cholula in Mexico\nThey invented toothpaste!.";

                count++;
                GameVariables.question1 = 0;
             
            }

        }

        if (count == 1)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT\n Sudan has more pyramids than Egypt.";
                GameVariables.question1 = 0;

                Destroy(enemy2);

                count++;
            }
            if (GameVariables.question1 == 2)
            {

                mytext.text = "INCORRECT\n Sudan has more pyramids than Egypt.";
                count++;
                GameVariables.question1 = 0;
            }

        }
        if (count == 2)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT\nDone";
                Destroy(mytext,3);
                GameVariables.question1 = 0;
                
                Destroy(TheWall);


                count++;
            }
            if (GameVariables.question1 == 2)
            {
                mytext.text = "INCORRECT\nDone";
                Destroy(enemy3);
                Destroy(mytext,3);
                count++;
                GameVariables.question1 = 0;
                Destroy(TheWall);
            }

        }


    }



}

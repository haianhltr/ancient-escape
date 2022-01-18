using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
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
                
                mytext.text = "INCORRECT, workers are paid with 4 liter per day\n Next Question: Cows were considered to be a sacred animal.";
               
                GameVariables.question1 = 0;
           
              
                count++;
            }
            if (GameVariables.question1 == 1)
            {
                Destroy(enemy1);
                mytext.text = "CORRECT, 4 liter per day\n Next Question: Cows were considered to be a sacred animal.";
               
                count++;
                GameVariables.question1 = 0;
             
            }

        }

        if (count == 1)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "INCORRECT, cats were considered to be a sacred animal by the Ancient Egyptians\n Next Question: The pyramids were built by paid laborers, not slaves.";
                GameVariables.question1 = 0;
               


                count++;
            }
            if (GameVariables.question1 == 2)
            {
                Destroy(enemy2);
                mytext.text = "CORRECT, cats were considered to be a sacred animal by the Ancient Egyptians\n Next Question: The pyramids were built by paid laborers, not slaves.";
                count++;
                GameVariables.question1 = 0;
            }

        }
        if (count == 2)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT, That's a myth by Herodotus the greek historian\nDone.";
                Destroy(mytext,3);
                GameVariables.question1 = 0;
                Destroy(enemy3);
                Destroy(TheWall);


                count++;
            }
            if (GameVariables.question1 == 2)
            {
                mytext.text = "INCORRECT, That's a myth by Herodotus the greek historian\nDone.";

                Destroy(mytext,3);
                count++;
                GameVariables.question1 = 0;
                Destroy(TheWall);
            }

        }


    }



}

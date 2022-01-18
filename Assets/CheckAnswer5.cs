using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer5 : MonoBehaviour
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

                mytext.text = "INCORRECT!\n Next Question: Most Egyptians were buried in Pyramids.";

                GameVariables.question1 = 0;
              

                count++;
            }
            if (GameVariables.question1 == 1)
            {

                mytext.text = "CORRECT!\n Next Question: Most Egyptians were buried in Pyramids.";
                Destroy(enemy1);
                count++;
                GameVariables.question1 = 0;

            }

        }

        if (count == 1)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "INCORRECT!\n Next Question: Most Egyptians knew how to write well.";
                GameVariables.question1 = 0;
               


                count++;
            }
            if (GameVariables.question1 == 2)
            {

                mytext.text = "CORRECT!\n Next Question: Most Egyptians knew how to write well.";
                count++;
                Destroy(enemy2);
                GameVariables.question1 = 0;
            }

        }
        if (count == 2)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "INCORRECT\nDone.";
                Destroy(mytext, 3);
                GameVariables.question1 = 0;
                
                Destroy(TheWall);


                count++;
            }
            if (GameVariables.question1 == 2)
            {
                mytext.text = "CORRECT\nDone.";
                Destroy(enemy3);
                Destroy(mytext, 3);
                count++;
                GameVariables.question1 = 0;
                Destroy(TheWall);
            }

        }


    }
}

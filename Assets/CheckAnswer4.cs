using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer4 : MonoBehaviour
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

                mytext.text = "CORRECT, The Egyptian alphabet contained more than 700 hieroglyphs!\n Next Question: The great pyramids are located at Giza, near modern day Cairo.";

                GameVariables.question1 = 0;
                Destroy(enemy1);

                count++;
            }
            if (GameVariables.question1 == 1)
            {

                mytext.text = "INCORRECT, The Egyptian alphabet contained more than 700 hieroglyphs!\n Next Question: The great pyramids are located at Giza, near modern day Cairo.";

                count++;
                GameVariables.question1 = 0;

            }

        }

        if (count == 1)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT, That's right, way to go!\n Next Question: Egyptians believed that cats held magical powers.";
                GameVariables.question1 = 0;
                Destroy(enemy2);


                count++;
            }
            if (GameVariables.question1 == 2)
            {

                mytext.text = "INCORRECT\n Next Question: Egyptians believed that cats held magical powers.";
                count++;
                GameVariables.question1 = 0;
            }

        }
        if (count == 2)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT\nDone.";
                Destroy(mytext, 3);
                GameVariables.question1 = 0;
                Destroy(enemy3);
                Destroy(TheWall);


                count++;
            }
            if (GameVariables.question1 == 2)
            {
                mytext.text = "INCORRECT\nDone.";

                Destroy(mytext, 3);
                count++;
                GameVariables.question1 = 0;
                Destroy(TheWall);
            }

        }


    }

}

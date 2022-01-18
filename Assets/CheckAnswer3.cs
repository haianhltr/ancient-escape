using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer3 : MonoBehaviour
{
    public Text mytext;
    public Text mytext2;
    int count = 0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5; public GameObject enemy6;
    public GameObject teleport;
    public GameObject TheWall;
    int count1= 0;
    int count2 = 0;
    
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        if (count == 0)
        {
            if (GameVariables.question1 == 2)
            {
                
                mytext.text = "CORRECT, Poseidon and Hades are his brothers.\n Next Question: The Greek Gods had human weaknesses.";
                count1++;
                GameVariables.question1 = 0;
           
              
                count++;
            }
            if (GameVariables.question1 == 1)
            {
                
                mytext.text = "INCORRECT, Poseidon and Hades are his brothers.\n Next Question: The Greek Gods had human weaknesses.";
                count2++;
                count++;
                GameVariables.question1 = 0;
             
            }

        }

        if (count == 1)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT, That's right, way to go! That's what probably made the Greek Gods so loveable!\n Next Question: The Olympian Gods were unaging?";
                GameVariables.question1 = 0;
                count1++;


                count++;
            }
            if (GameVariables.question1 == 2)
            {
                //Destroy(enemy2);
              
                mytext.text = "INCORRECT.\n Next Question: The Olympian Gods were unaging?";
                count2++;
                count++;
                GameVariables.question1 = 0;
            }

        }
        if (count == 2)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT, That's a myth by Herodotus the greek historian\n Next Question: Poseidon is the god of the sea?";
                count1++;
                GameVariables.question1 = 0;
                //Destroy(enemy3);
                


                count++;
            }
            if (GameVariables.question1 == 2)
            {
                mytext.text = "INCORRECT, That's a myth by Herodotus the greek historian\n Next Question: Poseidon is the god of the sea?";
                count2++;
                //Destroy(mytext,3);
                count++;
                GameVariables.question1 = 0;
              
            }

        }
        if (count == 3)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT\n Next Question: Hermes is both the guardian of travelers and master of thieves?";
                count1++;
                GameVariables.question1 = 0;
                //Destroy(enemy3);
                


                count++;
            }
            if (GameVariables.question1 == 2)
            {
                mytext.text = "INCORRECT\n Next Question: Hermes is both the guardian of travelers and master of thieves?";

                count2++;
                count++;
                GameVariables.question1 = 0;
                
            }

        }
        if (count == 4)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "CORRECT\n Next Question: Zeus is the male god behind Creation?";
                count1++;
                GameVariables.question1 = 0;
                //Destroy(enemy3);



                count++;
            }
            if (GameVariables.question1 == 2)
            {
                mytext.text = "INCORRECT\n Next Question: Zeus is the male god behind Creation?";

                count2++;
                count++;
                GameVariables.question1 = 0;

            }

        }
        if (count == 5)
        {

            if (GameVariables.question1 == 1)
            {
                mytext.text = "INCORRECT, he is thus not responsible for Creation. However, he is the most powerful god of Greek mythology.\n Unfortunately, you need more than 4 correct answer to unlock the gate\n The key is still in this room. Good luck!";
                //Destroy(mytext, 3);
                count2++;
                GameVariables.question1 = 0;
                //Destroy(enemy3);
                count++;

                if (count1 >= 4)
                {
                    Destroy(TheWall);
                    teleport.SetActive(true);
                    mytext.text = "CORRECT, he is thus not responsible for Creation. However, he is the most powerful god of Greek mythology.\n Here is the gate to the key";
                    Destroy(mytext, 3);
                }
                else
                {
                    mytext.text = "INCORRECT, he is thus not responsible for Creation. However, he is the most powerful god of Greek mythology.\n Unfortunately, you need more than 4 correct answer to unlock the gate\n The key is still in this room. Good luck!";
                    Destroy(mytext, 3);
                    enemy1.SetActive(true);
                    enemy2.SetActive(true);
                    enemy3.SetActive(true);
                    enemy4.SetActive(true);
                    enemy5.SetActive(true);
                    enemy6.SetActive(true);
                }

            }
            if (GameVariables.question1 == 2)
            {
                //mytext.text = "CORRECT, he is thus not responsible for Creation. However, he is the most powerful god of Greek mythology.\n Here is the gate to the key";
               
                count1++;

                count++;
                GameVariables.question1 = 0;

                if (count1 >= 4)
                {
                    Destroy(TheWall);
                    teleport.SetActive(true);
                    
                    mytext.text = "CORRECT, he is thus not responsible for Creation. However, he is the most powerful god of Greek mythology.\n Here is the gate to the key";
                    Destroy(mytext, 3);
                }
                else
                {
                    mytext.text = "INCORRECT\n Unfortunately, you need more than 4 correct answer to unlock the gate\n The key is still in this room. Remember, what's up!";
                    Destroy(mytext, 7);
                    enemy1.SetActive(true);
                    enemy2.SetActive(true);
                    enemy3.SetActive(true);
                    enemy4.SetActive(true);
                    enemy5.SetActive(true);
                    enemy6.SetActive(true);
                }

            }

        }





     
       
    }



}

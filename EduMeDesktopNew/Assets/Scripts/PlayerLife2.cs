using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife2 : MonoBehaviour
{
    public GameObject heart1,heart2,heart3,gameOver;
    public static int health2;
   
    void Start()
    {
        health2=DBManager.health2;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

       switch(health2){
           case 3:
           heart1.gameObject.SetActive(true);
           heart2.gameObject.SetActive(true);
           heart3.gameObject.SetActive(true);
           break;
           case 2:
           heart1.gameObject.SetActive(true);
           heart2.gameObject.SetActive(true);
           heart3.gameObject.SetActive(false);
           break;
           case 1:
           heart1.gameObject.SetActive(true);
           heart2.gameObject.SetActive(false);
           heart3.gameObject.SetActive(false);
           break;
           case 0:
           heart1.gameObject.SetActive(false);
           heart2.gameObject.SetActive(false);
           heart3.gameObject.SetActive(false);
           gameOver.gameObject.SetActive(true);
           break;
       } 
    }
}

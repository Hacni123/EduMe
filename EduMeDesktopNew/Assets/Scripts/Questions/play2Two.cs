using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class play2Two : MonoBehaviour
{
   public GameObject feed_benar, feed_salah;
   public Text playerDisplay;
	public Text scoreDisplay;
   public GameObject questionpanel2Two;
   public GameObject mez6;
   public GameObject correctAnswer;

   public void jawaban(bool jawab)
   {
         feed_benar.SetActive (false);
			feed_salah.SetActive (false);
         feed_salah.SetActive (false);
         if (jawab) 
         {
				feed_salah.SetActive (false);
				feed_benar.SetActive (true);
            correctAnswer.SetActive (false);   
				DBManager.score=DBManager.score+30;
				playerDisplay.text="Player :" +DBManager.username;
            scoreDisplay.text="Score :" +DBManager.score;	
            DBManager.multiplication1+=1; 
			} else 
         {
            correctAnswer.SetActive (true);
				feed_benar.SetActive (false);
				feed_salah.SetActive (true); 
            DBManager.multiplication2+=1;     
			}
			gameObject.SetActive(false);
         transform.parent.GetChild(gameObject.transform.GetSiblingIndex () +1).gameObject.SetActive(true);
            
            
   }
     public void continueButton()
     {
       Destroy(questionpanel2Two);
       Destroy(mez6);
     }   

     public void okButton()
     {
       Destroy(correctAnswer);
     } 
	
   
}


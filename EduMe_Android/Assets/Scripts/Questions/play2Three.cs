using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class play2Three : MonoBehaviour
{
   public GameObject feed_benar, feed_salah;
   public Text playerDisplay;
	public Text scoreDisplay;
   public GameObject questionpanel2Three;
   public GameObject mez8;
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
            DBManager.division1+=1; 
			} else 
         {
            correctAnswer.SetActive (true);
				feed_benar.SetActive (false);
				feed_salah.SetActive (true);   
            DBManager.division2+=1;   
			}
			gameObject.SetActive(false);
         transform.parent.GetChild(gameObject.transform.GetSiblingIndex () +1).gameObject.SetActive(true);        
   }
     public void continueButton()
     {
       Destroy(questionpanel2Three);
       Destroy(mez8);
     } 

     public void okButton()
     {
       Destroy(correctAnswer);
     }   
	
   
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class play2 : MonoBehaviour
{
   public GameObject feed_benar, feed_salah;
   public Text playerDisplay;
	public Text scoreDisplay;
   public GameObject questionpanel2;
   public GameObject mez1;
   public GameObject correctAnswer;

   
   public void jawaban(bool jawab)
   {
         feed_benar.SetActive (false);
			feed_salah.SetActive (false);
         feed_salah.SetActive (false);
      
         if (jawab) 
         {
				correctAnswer.SetActive (false);
				feed_benar.SetActive (true);
            feed_salah.SetActive (false);    
				if(DBManager.the_level==1)
				{
               DBManager.score1=DBManager.score1+30;
				   scoreDisplay.text="Score :" +DBManager.score1;    
				}
				else if(DBManager.the_level==2)
				{
               DBManager.score=DBManager.score2+50;
				   scoreDisplay.text="Score :" +DBManager.score2;    
				}
               DBManager.addition1+=1;
			} else 
         {
				correctAnswer.SetActive (true);
				feed_salah.SetActive (true);
            feed_benar.SetActive (false);     
				DBManager.addition2+=1;
			
			}
           
			gameObject.SetActive(false);
         transform.parent.GetChild(gameObject.transform.GetSiblingIndex () +1).gameObject.SetActive(true);
           
            
   }
     public void continueButton()
     {
       Destroy(questionpanel2);
       Destroy(mez1);
     } 

     public void okButton()
     {
       Destroy(correctAnswer);
     }   
	
    
}


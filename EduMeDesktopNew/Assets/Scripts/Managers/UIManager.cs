using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject gameOverPanel;
    public GameObject levelClearPanel;
    public GameObject questionpanel;
      public GameObject questionpanel2;
      public GameObject questionpanel3;
      public GameObject questionpanel4;
     public GameObject questionpanel2panel1;
     public GameObject questionpanel2panel2;
      public GameObject questionpanel2panel3;
       public GameObject questionpanel2panel4;
        public GameObject questionpanel2panel5;
         public GameObject questionpanel2panel6;
          public GameObject questionpanel2panel7;
           public GameObject questionpanel2panel8;
            public GameObject finishpanel1;
        public GameObject exitpanel;
    void start()
    {
        gameOverPanel.SetActive(false);
        levelClearPanel.SetActive(false);
        instance= this;
        
        
    }

    
    public void OnClickRetry()
    { 
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            Destroy(gameOverPanel);
            DBManager.score=0;
            DBManager.coins=0;
            DBManager.health=3;
            DBManager.x=0;
            DBManager.y=0;
            DBManager.z=0;
            DBManager.time=3600;
            DBManager.time1=4500;
            
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnClickMain()
    {
        Time.timeScale=1;
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
        SceneManager.LoadScene("MainMenu");
    }
    public void OnClickQuit()
    {
        Time.timeScale=1;
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
        Application.Quit();
    }

    public void OnGameOver()
    {  
       
        gameOverPanel.SetActive(true);
      
    }
        

    public void OnLevelClear()
    {
        levelClearPanel.SetActive(true);
        Time.timeScale = 1;
        if (SoundManager.instance != null)
            SoundManager.instance.levelcomplete();
    }
    public void OnLevelQuestion()
    {
        questionpanel.SetActive(true);
    
    }
    public void OnLevelQuestion2()
    {
        questionpanel2.SetActive(true);
    
    }
    public void OnLevelQuestion3()
    {
        questionpanel3.SetActive(true);
    
    }
    public void OnLevelQuestion4()
    {
        questionpanel4.SetActive(true);
    
    }
     public void OnLevelQuestion2panel1()
    {
        questionpanel2panel1.SetActive(true);
    
    }
     public void OnLevelQuestion2panel2()
    {
        questionpanel2panel2.SetActive(true);
    
    }
     public void OnLevelQuestion2panel3()
    {
        questionpanel2panel3.SetActive(true);
    
    }
     public void OnLevelQuestion2panel4()
    {
        questionpanel2panel4.SetActive(true);
    
    }
     public void OnLevelQuestion2panel5()
    {
        questionpanel2panel5.SetActive(true);
    
    }
     public void OnLevelQuestion2panel6()
    {
        questionpanel2panel6.SetActive(true);
    
    }
     public void OnLevelQuestion2panel7()
    {
        questionpanel2panel7.SetActive(true);
    
    }
     public void OnLevelQuestion2panel8()
    {
        questionpanel2panel8.SetActive(true);
    
    }
    
     public void showQuitPanel()
    {
        exitpanel.SetActive(true);
    
    }

     public void hideQuitPanel()
    {
        exitpanel.SetActive(false);
    
    }

     public void finishpanel()
    {
        finishpanel1.SetActive(true);
    
    }
    public void finishpanelhide()
    {
        finishpanel1.SetActive(false);
    
    }

     public void veiwallplayers()
    {
         SceneManager.LoadScene(7);
    
    }
}

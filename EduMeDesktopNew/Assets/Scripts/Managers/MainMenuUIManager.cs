using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuUIManager : MonoBehaviour
{
    public GameObject settingspanel;
    public GameObject highscore;
    public GameObject soundmanager;
    public GameObject exitpanel;
    public GameObject detailsInstructionpanel;
    public GameObject detailpanel;
    public GameObject instructionpanel;
    // Start is called before the first frame update
    public void OnClickStart()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
        SceneManager.LoadScene(3);
    }

    public void OnClickStart(GameObject settingspanel)
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            settingspanel.SetActive(true);
    }

    public void OnClickQuit()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            Application.Quit();
            Debug.Log("Quit");
    }

    public void OnClickHighscore()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            highscore.SetActive(true);
    }
   public void OnClickSoundManager()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            soundmanager.SetActive(true);
    }
   public void OnClickClose()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

     public void showQuitPanel()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            
        exitpanel.SetActive(true);
    
    }

     public void hideQuitPanel()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            
        exitpanel.SetActive(false);
    
    }

  public void OnClickdetailInstructionss()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
           
        detailsInstructionpanel.SetActive(true);
    }
     public void OnClickDetail()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
            
        detailpanel.SetActive(true);
    }

      public void OnClickInstructions()
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
          
        instructionpanel.SetActive(true);
    }

    public void veiwallplayers()
    {
         UnityEngine.SceneManagement.SceneManager.LoadScene(9);
    
    }
    
}

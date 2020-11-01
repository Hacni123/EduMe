using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    bool isPaused=false;
    private bool isMuted=false;

    public void PauseMenu1()
    {
        if(isPaused){
            Time.timeScale=1;
            isPaused=false;
            isMuted=false;
            AudioListener.pause=isMuted;
        }
        else{
            Time.timeScale=0;
            isPaused=true;
            isMuted=true;
            AudioListener.pause=isMuted;
           
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void OnClickButton(int level)
    {
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
        SceneManager.LoadScene("Level_" + level);
    }

  
}

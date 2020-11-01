using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgSource;
    public AudioSource sfxSource;
    public static SoundManager instance;
    
    public AudioClip jumpClip;
    public AudioClip buttonPressed;
    public AudioClip gameOver;
    public AudioClip levelComplete;
    public AudioClip coinClip;
    public AudioClip enemy;
    public AudioClip correct;
    public AudioClip wrong;



    // Start is called before the first frame update
    void Awake()
    {
       
        DontDestroyOnLoad(this);  
    
        if(instance== null)
             instance = this;
        else
             Destroy(gameObject);
        
    }

   
    public void PlayButtonPressSound()
    {
        sfxSource.clip = buttonPressed;
        sfxSource.Play();
    }

    public void PlayCoinSound()
    {
        sfxSource.clip = coinClip;
        sfxSource.Play();
    }

    public void PlayJumpSound()
    {
        sfxSource.clip = jumpClip;
        sfxSource.Play();
    }

    public void PlayOverSound()
    {
        sfxSource.clip = gameOver;
        sfxSource.Play();
    }

    public void levelcomplete()
    {
        sfxSource.clip = levelComplete;
        sfxSource.Play();
    }

    public void enemySound()
    {
        sfxSource.clip = enemy;
        sfxSource.Play();
    }

    public void correctSound()
    {
        sfxSource.clip = correct;
        sfxSource.Play();
    }
    public void wrongSound()
    {
        sfxSource.clip = wrong;
        sfxSource.Play();
    }

    
    
}

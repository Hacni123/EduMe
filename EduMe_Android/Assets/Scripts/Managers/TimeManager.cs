using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public GameObject gameOver;
    private float startingTime=DBManager.time;
    private float countingTime;
    private Text theText;

    //private PauseMenu thePauseMenu;
    void Start()
    {
        countingTime=DBManager.time;
        countingTime=startingTime;
        theText= GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countingTime -=Time.deltaTime;
        if(countingTime <=0)
        {
           gameOver.gameObject.SetActive(true);
        }
         theText.text= "" + Mathf.Round ((countingTime/60)%60)+"m"+" "+ Mathf.Round ((countingTime%60))+"s";
    }

    public void saveTime()
    {
        DBManager.time=countingTime;
    }


    }


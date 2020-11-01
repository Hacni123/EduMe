using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagement2 : MonoBehaviour
{
    public GameObject gameOver;
    private float startingTime=DBManager.time1;
    private float countingTime;
    private Text theText;

    //private PauseMenu thePauseMenu;
    void Start()
    {
        countingTime=DBManager.time1;
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
         theText.text= "" + Mathf.Round ((countingTime/3600)%60)+"h"+" "+ Mathf.Round ((countingTime/60)%60)+"s"+" "+ Mathf.Round ((countingTime%60))+"s";
    }

    public void saveTime()
    {
        DBManager.time1=countingTime;
    }


    }


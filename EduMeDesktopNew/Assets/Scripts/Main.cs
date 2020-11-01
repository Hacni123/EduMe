using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
   public Text PlayerDisplay;
    private void Start()
    {
        if(DBManager.LoggedIn)
        {
            PlayerDisplay.text="Player:"+ DBManager.username;
        }
    }
}

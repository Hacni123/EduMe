using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerController play1 = new Player1();
        
        play1.Start();
        play1.Awake();
        play1.Update();
        
        Player1 playone = (Player1)play1;

        playone.Update();

        PlayerController play2 = new Player2();

        play2.Start();
        play2.Awake();
        play2.Update();
        
        Player2 playtwo = (Player2)play2;

        playtwo.Update();


    }
    
}

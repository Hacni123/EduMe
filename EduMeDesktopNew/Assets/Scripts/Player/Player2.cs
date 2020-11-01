using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : PlayerController
{
    public override void Start()
     {
        base.Start();
        transform.position = new Vector3(DBManager.x,DBManager.y,DBManager.z);
        SavePosition();
     }
      public override void Awake()
     {
        if(DBManager.username==null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        base.Awake();
         
     }
     public override void Update()
     {
        base.Update();
       if (Input.GetKeyDown(KeyCode.Space))
        {
              base.Jump();
        }
     }

      public void CallSaveData()
    {
        StartCoroutine(base.SavePlayerData());
        StartCoroutine(base.SavePosition());

    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player1 : PlayerController
{
    // Start is called before the first frame update
     public override void Start()
     {
        base.Start();
        if(DBManager.the_level==1)
				{
                transform.position = new Vector3(DBManager.x,DBManager.y,DBManager.z); 
                 SavePosition();  
				}
		else if(DBManager.the_level==2)
				{
               transform.position = new Vector3(DBManager.x2,DBManager.y2,DBManager.z2);
               SavePosition2(); 
				}
       
       
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
    public void CallSaveData2()
    {
        StartCoroutine(base.SavePlayerData2());
        StartCoroutine(base.SavePosition2());

    }

    
    
}

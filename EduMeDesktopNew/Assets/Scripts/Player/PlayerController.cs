using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public float walkSpeed;
	public bool grounded;
    public float jumpForce;
    public UIManager uIManager;

    private Rigidbody2D rbd;
	private Animator anim;

    public Text playerDisplay;
	public Text scoreDisplay;
   
    public PlayerController()
    {
        walkSpeed=8;
        jumpForce=50f;
    }
    public virtual void Start()
    {
        playerDisplay.text="Player :" +DBManager.username;
        rbd = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();  
    }
    
    public virtual void Awake()
    {
        playerDisplay.text="Player :" +DBManager.username;
               if(DBManager.the_level==1)
                {
                   scoreDisplay.text="Score :" +DBManager.score1;  
                }
                else if(DBManager.the_level==2)
                {
                   scoreDisplay.text="Score :" +DBManager.score2;  
                }
         
    }

    public void updatenewscore()
    {
        if(DBManager.username==null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        playerDisplay.text="Player :" +DBManager.username;
       if(DBManager.the_level==1)
                {
                   scoreDisplay.text="Score :" +DBManager.score1;  
                }
                else if(DBManager.the_level==2)
                {
                   scoreDisplay.text="Score :" +DBManager.score2;  
                }   
    }

    public IEnumerator SavePlayerData()
    {
        WWWForm form= new WWWForm();
       
        form.AddField("name", DBManager.username);
        form.AddField("score1",DBManager.score1);
        form.AddField("score",DBManager.score1+DBManager.score2);
        form.AddField("coins",DBManager.coins);
        form.AddField("diamands",DBManager.diamands);
        form.AddField("level",DBManager.level);
        form.AddField("the_level",DBManager.the_level);
        form.AddField("health",DBManager.health);
        form.AddField("time",DBManager.time.ToString("0.00"));
        form.AddField("time1",DBManager.time1.ToString("0.00"));
        form.AddField("addition1",DBManager.addition1);
        form.AddField("substraction1",DBManager.substraction1);
        form.AddField("multiplication1",DBManager.multiplication1);
        form.AddField("division1",DBManager.division1);
        form.AddField("addition2",DBManager.addition2);
        form.AddField("substraction2",DBManager.substraction2);
        form.AddField("multiplication2",DBManager.multiplication2);
        form.AddField("division2",DBManager.division2);

        WWW www= new WWW("https://edumeuwu.000webhostapp.com/savedata.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("Game Saved");  
        }
        else
        {
            Debug.Log("Save failed. Error #" + www.text);    
        }
        DBManager.LogOut();
    
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

     public IEnumerator SavePlayerData2()
    {
        WWWForm form= new WWWForm();
       
        form.AddField("name", DBManager.username);
        form.AddField("score",DBManager.score1+DBManager.score2);
        form.AddField("score2",DBManager.score2);
        form.AddField("coins2",DBManager.coins2);
        form.AddField("diamands2",DBManager.diamands2);
        form.AddField("stars2",DBManager.stars2);
        form.AddField("level",DBManager.level);
        form.AddField("the_level",DBManager.the_level);
        form.AddField("health2",DBManager.health2);
        form.AddField("time",DBManager.time.ToString("0.00"));
        form.AddField("time1",DBManager.time1.ToString("0.00"));
        form.AddField("addition1",DBManager.addition1);
        form.AddField("substraction1",DBManager.substraction1);
        form.AddField("multiplication1",DBManager.multiplication1);
        form.AddField("division1",DBManager.division1);
        form.AddField("addition2",DBManager.addition2);
        form.AddField("substraction2",DBManager.substraction2);
        form.AddField("multiplication2",DBManager.multiplication2);
        form.AddField("division2",DBManager.division2);

        WWW www= new WWW("https://edumeuwu.000webhostapp.com/savedata2.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("Game Saved");  
        }
        else
        {
            Debug.Log("Save failed. Error #" + www.text);    
        }
        DBManager.LogOut();
    
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
      
   public IEnumerator SavePosition() {
        WWWForm form= new WWWForm();
       
        form.AddField("name", DBManager.username);
        form.AddField("x", transform.position.x.ToString("0.00"));
        form.AddField("y", transform.position.y.ToString("0.00"));
        form.AddField("z", transform.position.z.ToString("0.00"));
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/Insertpos.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("Game position Saved"); 
        }
        else
        {
            Debug.Log("Save position failed. Error #" + www.text);   
        }
     }

      public IEnumerator SavePosition2() {
        WWWForm form= new WWWForm();
       
        form.AddField("name", DBManager.username);
        form.AddField("x", transform.position.x.ToString("0.00"));
        form.AddField("y", transform.position.y.ToString("0.00"));
        form.AddField("z", transform.position.z.ToString("0.00"));
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/savepos2.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("Game position Saved"); 
        }
        else
        {
            Debug.Log("Save position failed. Error #" + www.text);   
        }
     }
    // Update is called once per frame
    public virtual void Update()
    { 
        float x = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(x));
        anim.SetBool("Grounded", grounded);
        if (x > 0)
            transform.localScale = Vector2.one;
        else if (x < 0)
            transform.localScale = new Vector2(-1, 1);
            rbd.velocity = new Vector2(x * walkSpeed, rbd.velocity.y);
         
        if(transform.position.y <=-7f)
        {
            anim.SetTrigger("Death");
            uIManager.OnGameOver();   
        }
        
         playerDisplay.text="Player :" +DBManager.username;
               if(DBManager.the_level==1)
                {
                   scoreDisplay.text="Score :" +DBManager.score1;  
                }
                else if(DBManager.the_level==2)
                {
                   scoreDisplay.text="Score :" +DBManager.score2;  
                }
         
        
    }

    public void Jump ()
	{
		if(grounded)
		{
            if (SoundManager.instance != null)
                SoundManager.instance.PlayJumpSound();
            rbd.AddForce(Vector2.up*jumpForce);
		}
	}

    protected virtual void OnTriggerEnter2D(Collider2D target)
	{
        if(target.gameObject.tag=="Coin")
	    {
            if (SoundManager.instance != null)
                SoundManager.instance.PlayCoinSound();
                if(DBManager.the_level==1)
                {
                   CoinManager.instance.UpdateCoin();
                   DBManager.score1=DBManager.score1+5;
                   Destroy(target.gameObject);
                }
                else if(DBManager.the_level==2)
                {
                   CoinManager.instance.UpdateCoin2();
                   DBManager.score2=DBManager.score2+5;
                   Destroy(target.gameObject);
                }
	    }
        else if(target.gameObject.tag=="diamand")
	    {
            if (SoundManager.instance != null)
                SoundManager.instance.PlayCoinSound(); 
                
           if(DBManager.the_level==1)
                {
                   CoinManager.instance.UpdateDiamands();
                   DBManager.score1=DBManager.score1+10;
                   Destroy(target.gameObject);
                }
                else if(DBManager.the_level==2)
                {
                   CoinManager.instance.UpdateDiamands2();
                   DBManager.score2=DBManager.score2+10;
                   Destroy(target.gameObject);
                }
	    }
         else if(target.gameObject.tag=="star")
	    {
            if (SoundManager.instance != null)
                SoundManager.instance.PlayCoinSound(); 
                 
            if(DBManager.the_level==1)
                {
                  
                   DBManager.score1=DBManager.score1+15;
                   Destroy(target.gameObject);
                }
                else if(DBManager.the_level==2)
                {
                   CoinManager.instance.UpdateStars2();
                   DBManager.score2=DBManager.score2+15;
                   Destroy(target.gameObject);
                }
            
		    scoreDisplay.text="Score:"+DBManager.score;
		    Destroy(target.gameObject);
	    }
        else if(target.gameObject.tag=="Spike")
        {
            if (SoundManager.instance != null)
                SoundManager.instance.enemySound();
                
                
               if(DBManager.the_level==1)
                {
                    PlayerLife.health=DBManager.health-1;
                    if(PlayerLife.health<0)
                     {
                       DBManager.health=0;  
                     }
                     else
                     {
                        DBManager.health=PlayerLife.health;
                      } 
                }
                else if(DBManager.the_level==2)
                {
                    PlayerLife2.health2=DBManager.health2-1;
                     if(PlayerLife2.health2<0)
                     {
                       DBManager.health2=0;  
                     }
                     else
                     {
                        DBManager.health2=PlayerLife2.health2;
                      }
                } 
        }
        else if(target.gameObject.tag=="Finish")
        {
             uIManager.finishpanel(); 
        }

        else if (target.gameObject.name == "house")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2panel1(); 
            SavePlayerData();
        }
        else if (target.gameObject.name == "house1")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2panel2();  
            SavePlayerData();
        }
         else if (target.gameObject.name == "house2")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2panel3();  
            SavePlayerData();
        }
         else if (target.gameObject.name == "house3")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2panel4();
            SavePlayerData();
        }
         else if (target.gameObject.name == "house00")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2panel5();  
            SavePlayerData();
        }
         else if (target.gameObject.name == "house11")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2panel6();  
            SavePlayerData();
        }
         else if (target.gameObject.name == "house22")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2panel7();  
            SavePlayerData();
        }
         else if (target.gameObject.name == "house33")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2panel8();  
            SavePlayerData();
        }
        else if (target.gameObject.name == "friend1")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion();  
            SavePlayerData();    
        }
        else if (target.gameObject.name == "friend2")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion2();  
            SavePlayerData();      
        }
         else if (target.gameObject.name == "friend3")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion3();  
            SavePlayerData();     
        }
         else if (target.gameObject.name == "friend4")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion4();  
            SavePlayerData();     
        }
        else if (target.gameObject.name == "friend11")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion11();  
            SavePlayerData();    
        }
        else if (target.gameObject.name == "friend22")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion22();  
            SavePlayerData();      
        }
         else if (target.gameObject.name == "friend33")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion33();  
            SavePlayerData();     
        }
         else if (target.gameObject.name == "friend44")
        {
            Destroy(target.gameObject);
            uIManager.OnLevelQuestion44();  
            SavePlayerData();     
        }
    }
    
}

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
        rbd = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();  
    }
    
    public virtual void Awake()
    {
        playerDisplay.text="Player :" +DBManager.username;
        scoreDisplay.text="Score :" +DBManager.score;   
    }

    public void updatenewscore()
    {
        if(DBManager.username==null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        playerDisplay.text="Player :" +DBManager.username;
        scoreDisplay.text="Score :" +DBManager.score;     
    }

    public IEnumerator SavePlayerData()
    {
        WWWForm form= new WWWForm();
       
        form.AddField("name", DBManager.username);
        form.AddField("score",DBManager.score);
        form.AddField("coins",DBManager.coins);
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
            CoinManager.instance.UpdateCoin();
            DBManager.score=DBManager.score+5;
            
		    scoreDisplay.text="Score:"+DBManager.score;
		    Destroy(target.gameObject);
	    }
        else if(target.gameObject.tag=="diamand")
	    {
            if (SoundManager.instance != null)
                SoundManager.instance.PlayCoinSound(); 
            DBManager.score=DBManager.score+10;
            
		    scoreDisplay.text="Score:"+DBManager.score;
		    Destroy(target.gameObject);
	    }
        else if(target.gameObject.tag=="Spike")
        {
            if (SoundManager.instance != null)
                SoundManager.instance.enemySound();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour {
    public int Coins_To_Unlocked;
    public GameObject Next_Level;
    public int max_level;
    public string num_level;
    public static int thelevel;
    public int t;
	// Use this for initialization
	void Start () {
        //CoinsManager.Coins = 0;
        thelevel = DBManager.the_level;
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 1; i < max_level; i++)
        {
            if ( DBManager.score1 == Coins_To_Unlocked && LevelUnlocked.level == i)
            {
                Next_Level.SetActive(true);
            }
            else if ( DBManager.score2 == Coins_To_Unlocked && LevelUnlocked.level == i)
            {
                Next_Level.SetActive(true);
            }
            else if ( DBManager.score3 == Coins_To_Unlocked && LevelUnlocked.level == i)
            {
                Next_Level.SetActive(true);
            }
            else if ( DBManager.score4 == Coins_To_Unlocked && LevelUnlocked.level == i)
            {
                Next_Level.SetActive(true);
            }
        }
	}
    public static void the_level(int t)
    {
        thelevel = t;
        DBManager.the_level=thelevel;
    }
    public void next()
    {
           
        LevelUnlocked.Next_Level();
        SceneManager.LoadScene("LevelSelect");
    }
    public void _level()
    {
        the_level(t);
        Application.LoadLevel(num_level);
        SceneManager.LoadScene(num_level);
    }
}

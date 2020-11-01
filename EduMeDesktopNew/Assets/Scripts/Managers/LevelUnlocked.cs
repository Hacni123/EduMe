using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelUnlocked : MonoBehaviour {
    public static int level=1;
    public int max_level;
    public GameObject[] levelUnlocked;
	// Use this for initialization
	void Start () {
        level = DBManager.level;
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 1; i < max_level; i++)
        {

            if (i <= level)
            {
                levelUnlocked[i].SetActive(false);
                Debug.Log("" + level);

            }
            else
            {
                levelUnlocked[i].SetActive(true);
                Debug.Log("" + level);
            }
        }
	}
    public static void Next_Level()
    {
        if (level == NextLevel.thelevel)
        {
            level += 1;
            DBManager.level=level;
        }
    }
    public void Reset()
    {
        level = 1;
        DBManager.level=level;
    }

    public void add_level()
    {
        Next_Level();
        SceneManager.LoadScene("LevelSelect");
    }
}

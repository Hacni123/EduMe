using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour {

	public Text coinText;
	public Text diamandText;
	public Text starText;
	public int coinCount;
	public int diamandCount;
	public int starCount;
      
	
	public static CoinManager instance;
	void Start () {
		instance= this;
		
		        if(DBManager.the_level==1)
                {
                   coinCount=DBManager.coins;
		           diamandCount=DBManager.diamands;
                }
                else if(DBManager.the_level==2)
                {
                   coinCount=DBManager.coins2;
		           diamandCount=DBManager.diamands2;
				   starCount=DBManager.stars2;
                }
	}
	
	// Update is called once per frame
	void Update () {
		coinText.text = coinCount+"";
		diamandText.text = diamandCount+"";
		starText.text = starCount+"";
	}
	public void UpdateCoin()
	{
		coinCount=coinCount +1;
		DBManager.coins=DBManager.coins+1;
	}
	public void UpdateDiamands()
	{
		diamandCount=diamandCount +1;
		DBManager.diamands=DBManager.diamands+1;
	}
	public void UpdateCoin2()
	{
		coinCount=coinCount +1;
		DBManager.coins2=DBManager.coins2+1;
	}
	public void UpdateDiamands2()
	{
		diamandCount=diamandCount +1;
		DBManager.diamands2=DBManager.diamands2+1;
	}
	public void UpdateStars2()
	{
		starCount=starCount +1;
		DBManager.stars2=DBManager.stars2+1;
	}
}

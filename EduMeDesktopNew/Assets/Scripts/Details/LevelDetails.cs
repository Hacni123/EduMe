using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class LevelDetails : Details
{
   public Text details;
    protected string secretKey = "mySecretKey"; // Edit this value and make sure it's the same as the one stored on the server
    
    public string leveldetails = "https://edumeuwu.000webhostapp.com/getLevelData.php";

    public override void Start()
    {
        StartCoroutine(GetDetails());
    }
 
   
 
    // Get the scores from the MySQL DB to display in a GUIText.
    // remember to use StartCoroutine when calling this function!
    public override IEnumerator GetDetails()
    {
        
        WWW hs_get = new WWW(leveldetails);
        yield return hs_get;
 
        if (hs_get.error != null)
        {
            print("There was an error getting the Level Details: " + hs_get.error);
        }
        else
        {
            details.text = hs_get.text; // this is a GUIText that will display the scores in game.
        }
    }
 
}
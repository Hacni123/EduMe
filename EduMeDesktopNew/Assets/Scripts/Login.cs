using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Login : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    protected string name = "";
    public Button submitButton;
    public Text Description = null;
	private static Text _Descrip = null;
    
    public void CallLogin()
    {
        StartCoroutine(LoginUser());
    }

    public void OnClickRegister()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public  IEnumerator LoginUser()
    {
        WWWForm form= new WWWForm();
        form.AddField("name", nameField.text);
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/LoginUser.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
               DBManager.username=nameField.text;
               DBManager.score=int.Parse(www.text.Split('\t')[1]);
               DBManager.score1=int.Parse(www.text.Split('\t')[2]);
               DBManager.score2=int.Parse(www.text.Split('\t')[3]);
               DBManager.score3=int.Parse(www.text.Split('\t')[4]);
               DBManager.score4=int.Parse(www.text.Split('\t')[5]);
               DBManager.coins=int.Parse(www.text.Split('\t')[6]);
               DBManager.diamands=int.Parse(www.text.Split('\t')[7]);
               DBManager.coins2=int.Parse(www.text.Split('\t')[8]);
               DBManager.diamands2=int.Parse(www.text.Split('\t')[9]);
               DBManager.stars2=int.Parse(www.text.Split('\t')[10]);
               DBManager.x=float.Parse(www.text.Split('\t')[11]);
               DBManager.y=float.Parse(www.text.Split('\t')[12]);
               DBManager.z=float.Parse(www.text.Split('\t')[13]);
               DBManager.x2=float.Parse(www.text.Split('\t')[14]);
               DBManager.y2=float.Parse(www.text.Split('\t')[15]);
               DBManager.z2=float.Parse(www.text.Split('\t')[16]);
               DBManager.level=int.Parse(www.text.Split('\t')[17]);
               DBManager.the_level=int.Parse(www.text.Split('\t')[18]);
               DBManager.health=int.Parse(www.text.Split('\t')[19]);
               DBManager.health2=int.Parse(www.text.Split('\t')[20]);
               DBManager.time=float.Parse(www.text.Split('\t')[21]);
               DBManager.time1=float.Parse(www.text.Split('\t')[22]);
               UpdateDescription("User logging successfully");
               UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
        else
        {
            Debug.Log("User login failed. Error #" + www.text);
            UpdateDescription("User login failed, Incorrect username");
        }

    }
public void Loginusertosystem()
	{
		if (nameField.text != string.Empty)
		{
			StartCoroutine(LoginUser());	
		}
		else
		{
			if (nameField.text == string.Empty)
			{
			  UpdateDescription("Name Field is empty");
			}	
		}
	}
    void UpdateDescription(string descText)
	{
        _Descrip = Description;
		_Descrip.text = descText;
	}
}

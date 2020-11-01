using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoginTeacher : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    protected string name = "";
	protected string username = "";

    public Button submitButton;

    public Text Description = null;
	private static Text _Descrip = null;
    
    public void CallLogin()
    {
        
        StartCoroutine(LoginUser());
    }

    public void OnClickRegister()
    {
        
            UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }

    public  IEnumerator LoginUser()
    {
        WWWForm form= new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/loginteacher.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
              
            UpdateDescription("User logging successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(7);
        }
        else
        {
            Debug.Log("User login failed. Error #" + www.text);
            UpdateDescription("User login failed, Incorrect User Name or Password");
        }

    }
public void Loginusertosystem()
	{

		if (nameField.text != string.Empty && passwordField.text != string.Empty)
		{
			
				StartCoroutine(LoginUser());
			
			
		}
		else
		{
			if (nameField.text == string.Empty)
			{
				UpdateDescription("User Name Field is empty");
			}
			if (passwordField.text == string.Empty)
			{
			    UpdateDescription("Password Field is empty");
			}
			
            if (nameField.text == string.Empty && passwordField.text == string.Empty)
			{
				UpdateDescription("Complete all the fields above.");
			}
			
			
		}
	}
    void UpdateDescription(string descText)
	{
        _Descrip = Description;
		_Descrip.text = descText;
	}
    
}

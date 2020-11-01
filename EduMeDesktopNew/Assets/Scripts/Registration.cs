using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField age;
    public Button submitButton;
    protected string name = "";
	protected string age1 = "";
    public Text Description = null;
	private static Text _Descrip = null;

    public void OnClickLogin()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public  IEnumerator Register()
    {
        WWWForm form= new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("age", age.text);
        
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/RegisterUser.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("User created successfully");
            UpdateDescription("User created successfully");
             UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("User creation failed. Error #" +www.text);
            UpdateDescription(" "+www.text);
        }
    }
   public void RegisterUser()
	{

		if (nameField.text != string.Empty && age.text != string.Empty)
		{
			StartCoroutine(Register());	
		}
		else
		{
			if (nameField.text == string.Empty)
			{
				UpdateDescription("User Name Field is empty");
			}
			
			if (age.text == string.Empty)
			{
				UpdateDescription("Age Field is empty");
			}
            if (nameField.text == string.Empty  && age.text == string.Empty)
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

    public void Toggle_Changed(bool newValue)
    {
         UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }

    
}

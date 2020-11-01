using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getallstudentdetails : MonoBehaviour
{
    public InputField nameField;
    public Text username;
    public Text age;
    public Text score;
    public Text time;
    public Text time1;
    public Text addition1;
    public Text substraction1;
    public Text multiplication1;
    public Text division1;
    public Text Description = null;
    public Text Description1 = null;
	
    private int add1;
    private int sub1;
    private int mul1;
    private int div1;
    private int add2;
    private int sub2;
    private int mul2;
    private int div2;
    
    public GameObject exitpanel;
    public GameObject resetpanel;
    private float timefirst;
    private float timesecond;
    
    public void StartgetDetails()
    {
       StartCoroutine(StudentDetails()); 
    }

    
    public void DeleteDetails1()
    {
       StartCoroutine(DeleteDetails()); 
    }

     public void ResetDetails1()
    {
       StartCoroutine(ResetDetails()); 
        StartCoroutine(ResetPosition()); 
      
    }

    public  IEnumerator StudentDetails()
    {
        WWWForm form= new WWWForm();
        form.AddField("name", nameField.text);
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/studentDetails.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
             Description.text="Please wait. Data Loading...";  
               username.text=www.text.Split('\t')[1];
               age.text=www.text.Split('\t')[2];
               score.text=www.text.Split('\t')[3];
               timefirst=float.Parse(www.text.Split('\t')[4]);
               timesecond=float.Parse(www.text.Split('\t')[5]);
               add1=int.Parse(www.text.Split('\t')[6]);
               sub1=int.Parse(www.text.Split('\t')[7]);
               mul1=int.Parse(www.text.Split('\t')[8]);
               div1=int.Parse(www.text.Split('\t')[9]);
               add2=int.Parse(www.text.Split('\t')[10]);
               sub2=int.Parse(www.text.Split('\t')[11]);
               mul2=int.Parse(www.text.Split('\t')[12]);
               div2=int.Parse(www.text.Split('\t')[13]);
               if(timefirst==0 || timesecond==0)
               {
                   time.text="0";
                   time1.text="0";
               }
               else
               {
                  time.text=(3600-timefirst).ToString("0.00");
                  time1.text=(4500-timesecond).ToString("0.00");
               }

               if(add1==0 && add2==0)
               {
                addition1.text="Not solve yet";
               }
               else{
                  if(add1==0)
                  {
                    addition1.text="0 %";
                  }
                  else
                  {
                   addition1.text=add1+"/"+(add1+add2);
                }
               }

               if(sub1==0 && sub2==0)
               {
               substraction1.text="Not solve yet";
              }
               else{
                 if(sub1==0)
                 {
                      substraction1.text="0 %";
                  }
                 else
                  {
                       substraction1.text=sub1+"/"+(sub1+sub2);
                  
               }
               }

               if(mul1==0 && mul2==0)
              {
                 multiplication1.text="Not solve yet";
              }
              else{
                   if(mul1==0)
                 {
                       multiplication1.text="0 %";
                  }
                  else
                  {
                      multiplication1.text=mul1+"/"+(mul1+mul2);
                  
               }
                }

                 if(div1==0 && div2==0)
               {
                 division1.text="Not solve yet";
               }
               else{
                   if(div1==0)
                  {
                       division1.text="0 %";
                  }
                  else
                  {
                      division1.text=div1+"/"+(div1+div2); 
                  
               }
                }   
                   
        }
        else
        {
            Description.text="User Name is not exit";
            Debug.Log("User login failed. Error #" + www.text);

        }

    }

    public IEnumerator DeleteDetails()
    {
        
        WWWForm form= new WWWForm();
        form.AddField("name", nameField.text);
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/DeleteData.php",form);
         yield return www;
        if(www.text[0]=='0')
        {
           Description1.text="Player deleted successfully";
           exitpanel.SetActive(false);
           username.text=" ";
           age.text=" ";
           score.text=" ";
           time.text=" ";
           time1.text=" ";
           addition1.text=" ";
           substraction1.text=" ";
           multiplication1.text=" ";
           division1.text=" ";
           Description.text =" ";
        }
        else
        {
            Description1.text="Player not deleted.";
        }
        
    }

    public IEnumerator ResetDetails()
    {
        
        WWWForm form= new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("score",0);
        form.AddField("coins",0);
        form.AddField("level",1);
        form.AddField("the_level",1);
        form.AddField("health",3);
        form.AddField("time",3600);
        form.AddField("time1",4500);
        form.AddField("addition1",0);
        form.AddField("substraction1",0);
        form.AddField("multiplication1",0);
        form.AddField("division1",0);
        form.AddField("addition2",0);
        form.AddField("substraction2",0);
        form.AddField("multiplication2",0);
        form.AddField("division2",0);

        WWW www= new WWW("https://edumeuwu.000webhostapp.com/savedata.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("Data Reset");  
        }
        else
        {
            Debug.Log("Reset failed. Error #" + www.text);    
        }
        
    }

    public IEnumerator ResetPosition()
    {
         WWWForm form= new WWWForm();
       
        form.AddField("name", nameField.text);
        form.AddField("x",0);
        form.AddField("y",0);
        form.AddField("z",0);
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/Insertpos.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("Reset position Saved"); 
        }
        else
        {
            Debug.Log("Reset position failed. Error #" + www.text);   
        }
    }

     public void OnClickMain2()
    {
        Time.timeScale=1;
        if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
        SceneManager.LoadScene("TeacherMain");
    }

     public void showQuitPanel()
    {
        exitpanel.SetActive(true);
    
    }

     public void hideQuitPanel()
    {
        exitpanel.SetActive(false);
    
    }

     public void showResetPanel()
    {
        resetpanel.SetActive(true);
    
    }

     public void hideResetPanel()
    {
        resetpanel.SetActive(false);
    
    }
    
}

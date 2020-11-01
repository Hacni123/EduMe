using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    public static string username;
    public static int score;
    public static int coins;
    public static float x;
    public static float y;
    public static float z;
    public static int level;
    public static int the_level;
    public static int health;
    public static float time;
    public static float time1;
    public static int addition1;
    public static int substraction1;
    public static int multiplication1;
    public static int division1;
    public static int addition2;
    public static int substraction2;
    public static int multiplication2;
    public static int division2;


    public static bool LoggedIn{ get { return username != null; }}

    public static void LogOut()
    {
        username=null;
    }

    
     
    

}

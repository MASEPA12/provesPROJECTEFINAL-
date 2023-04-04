using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataPersistence : MonoBehaviour
{
    public static dataPersistence sharedInstance;

    public string username;
    public int score;

    private void Awake()
    {
        //if variable is null
        if (sharedInstance == null)
        {
            sharedInstance = this; //get the value of the script
            DontDestroyOnLoad(this); //Dont destroy when changing scene
        }
        else 
        {
            Destroy(gameObject); //Destroy copy 
        }
    }
}

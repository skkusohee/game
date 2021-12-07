using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class UIManagerment : MonoBehaviour
{
    public Text Count;
    public int Mark;
    public Text Life;
    public int chk;

    // Start is called before the first frame update
    void Start()
    {
        Mark = 0;
        chk = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Mark += 1;
        Count.text = "SCORE   " + Mark;
        
        if(Int32.Parse(Life.text) > 0)
        {
            chk += 1;
            if (chk == 1000)
            {
                int life = Int32.Parse(Life.text);
                life--;
                Life.text = "" + life;
                chk = 0;
            }
        }
        else
        {
            //여기  
            SceneManager.LoadScene("menu");
        }
    
    }
 
       

   
}

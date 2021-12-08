using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Cheeze : MonoBehaviour
{
    public GameObject gameObject;
    public float life;
    public Text text;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            life = Int32.Parse(text.text);
            life++;
            text.text = "" + life;
            gameObject.SetActive(false);
            //Destroy(gameObject);
           
        }
    }
}

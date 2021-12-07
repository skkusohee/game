using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheeze : MonoBehaviour
{
    public GameObject gameObject;
    public float life = 10;
    public Text text;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("cheeze");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("asdfasdf");
            life++;
            Debug.Log(life);
            text.text = "" + life;
            Destroy(gameObject);
           
        }
    }
}

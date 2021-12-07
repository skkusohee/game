using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    void Start()
    {
        
    }
    private float speed = 2f;
    private float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 25f)
        {
            speed += 0.6f;
            timer = 0;
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}

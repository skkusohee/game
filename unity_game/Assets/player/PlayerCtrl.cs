using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerCtrl : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private Collider2D coll;
    //public float life=100;
    public float rotation = 1f;
    public Text text;
    public float speed=5f;
    public float x;
  
    public float xVelocity;

    
    public float jumpForce = 6f;

    int jumpCount;

    
    public bool isOnGround;

    
    public LayerMask groundLayer;


    bool jumpPress;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpPress = true;
        }
       // MoveUpdate();
      //  updateLife();
    }
    /*
    void updateLife()
    {
        rotation -= Time.deltaTime;
        if (rotation < 0)
        {
            life--;
            rotation = 1f;
        }
        if (life < 0)
        {
            gameObject.SetActive(false);
        }
    }

    */
    void FixedUpdate()
    {
        isOnGroundCheck();
        Move();
        Jump();
    }

    void isOnGroundCheck()
    {
        ////判断角色碰撞器与地面图层发生接触
        if (coll.IsTouchingLayers(groundLayer))
        {
            isOnGround = true;
        }
        else
        {
            isOnGround = false;
        }
    }

    void Move()
    {
        xVelocity = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);

        //镜面翻转
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(-xVelocity, 1, 1);
        }
    }

    void Jump()
    {
        //在地面上
        if (isOnGround)
        {
            jumpCount = 1;
        }
        //在地面上跳跃
        if (jumpPress && isOnGround)
        {
            anim.SetTrigger("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
            jumpPress = false;
        }
        //在空中跳跃
        else if (jumpPress && jumpCount > 0 && !isOnGround)
        {
            anim.SetTrigger("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
            jumpPress = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cat")
        {
            SceneManager.LoadScene("end");
            Time.timeScale = 0;
            //gameObject.SetActive(false);
        }else if(collision.gameObject.tag == "Obstacle")
        {
            GameObject tom = GameObject.FindWithTag("Cat");
            if (tom != null)
            {
                StartCoroutine(CatSecond(tom, 2f));
            }
            //collision.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cheese")
        {
            //life++;
            //Debug.Log(life);
            //text.text = "" + life;
            //collision.gameObject.SetActive(false);
        }
    }
    void death()
    {
        if(Int32.Parse(text.text) == 0)
        {
            SceneManager.LoadScene("end");
            //gameObject.SetActive(false);
        }

    }
    void MoveUpdate()
    {
        x = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x+speed*Time.deltaTime*x, transform.position.y, transform.position.z);
        
    }

    IEnumerator CatSecond(GameObject obj, float second)
    {
        obj.transform.position = new Vector3(-10, -1, 0);
        //obj.SetActive(false);
        yield return new WaitForSeconds(second);
        obj.transform.position = new Vector3(-6, -1, 0);
        //obj.SetActive(true);
    }
}
    

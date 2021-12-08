using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{

    public float speed;
    public float startPosition;
    public float endPosition;
    public Transform[] cheese;
    public Transform[] obstacle;

    void Update()
    {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        if(transform.position.x <= endPosition)
        {
            ScrollEnd();
        }
    }

    void ScrollEnd()
    {
        transform.Translate(-1 * (endPosition - startPosition), 0, 0);
  //      cheese = GameObject.FindGameObjectsWithTag("Cheese");
//        obstacle = GameObject.FindGameObjectsWithTag("Obstacle");

        cheese = transform.FindChild("Cheeze").transform.GetComponentsInChildren<Transform>(true);
        
        obstacle = transform.FindChild("Obstacle").transform.GetComponentsInChildren<Transform>(true);
        //GameObject.Find("Cheeze").transform.GetComponentsInChildren<GameObject>().gameObject.SetActive(true);
        //GameObject.Find("Obstacle").transform.GetComponentsInChildren<GameObject>().gameObject.SetActive(true);

        for (int i = 0; i < cheese.Length; i++)
        {
            cheese[i].gameObject.SetActive(true);
            if (cheese[i] == null) Debug.Log("null");
        }
        for (int i = 0; i < obstacle.Length; i++)
        {
            obstacle[i].gameObject.SetActive(true);
            if (obstacle[i] == null) Debug.Log("null");
        }
    }
    /*
    public float mapSpeed = 10f;
    public bool isCreate = false;
    public CreateMap createMap;
    // Update is called once per frame
    private void Start()
    {
        isCreate = false;
        gameObject.SetActive(true);
    }
    void Update()
    {
        createMapdemo();
        transform.Translate(-mapSpeed * Time.deltaTime, 0, 0);
    }
    void createMapdemo()
    {
        if (transform.position.x <= -8&&isCreate==false)
        {
            createMap.create();
            isCreate = true;
        }
        if (transform.position.x <-27)
        {
           // gameObject.SetActive(false);
        }
    }
    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
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
}

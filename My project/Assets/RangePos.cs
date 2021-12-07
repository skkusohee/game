using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangePos : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public bool isBool = false;
    public GameObject cheese;
    public GameObject cheese1;
    public void Start()
    {
        
    }
    private void OnEnable()
    {
        InitPosition();
    }
    public void InitPosition()
    {
        if (!isBool)
        {
            transform.localPosition = new Vector2(Random.Range(transform.localPosition.x, transform.localPosition.x + 0.5f), Random.Range(transform.localPosition.y, transform.localPosition.y + 0.5f));
        }
        else
        {
            transform.localPosition = new Vector2(Random.Range(transform.localPosition.x, transform.localPosition.x + 0.5f), transform.localPosition.y);
        }
        cheese.SetActive(true);
        cheese1.SetActive(true);
        GetComponent<RangePos>().enabled = false;

    }
}

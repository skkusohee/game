using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour
{
    public GameObject gameObject;
    public static CreateMap instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void create()
    {
        Quaternion quaternion = Quaternion.Euler(0f,0f,Random.Range(0f,0f));
        Instantiate(gameObject, transform.position, quaternion);
    }
}

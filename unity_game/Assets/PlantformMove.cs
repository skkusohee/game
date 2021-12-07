using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantformMove : MonoBehaviour
{
    public Transform plantform1;
    public Transform plantform2;
    public Transform _camera;
    private bool isBool = false;
    private bool isBool1 = false;
    private void Update()
    {
        if (!isBool1)
        {
            if (!isBool)
            {
                if (_camera.localPosition.x >= plantform2.localPosition.x)
                {
                    plantform1.localPosition = new Vector3(plantform1.localPosition.x + 50.4f, plantform1.localPosition.y, plantform1.localPosition.z);
                    plantform1.GetComponent<PipeManager>().ChangeStatu(true);
                    Invoke("Delay2", 0.1f);
                    isBool1 = true;
                }
            }
            else
            {
                if (_camera.localPosition.x >= plantform1.localPosition.x)
                {
                    plantform2.localPosition = new Vector3(plantform2.localPosition.x + 50.4f, plantform2.localPosition.y, plantform2.localPosition.z);
                    plantform2.GetComponent<PipeManager>().ChangeStatu(true);
                    Invoke("Delay1", 0.1f);
                    isBool1 = true;
                }
            }
        }
    }
    void Delay1()
    {
        isBool = false;
        isBool1 = false;
    }
    void Delay2()
    {
        isBool = true;
        isBool1 = false;
    }
}

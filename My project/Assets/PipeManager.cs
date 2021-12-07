using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public List<RangePos> rangePos = new List<RangePos>();

    public void ChangeStatu(bool isActive)
    {
        for (int i = 0; i < rangePos.Count; i++)
        {
            rangePos[i].enabled = isActive;
        }
    }
}

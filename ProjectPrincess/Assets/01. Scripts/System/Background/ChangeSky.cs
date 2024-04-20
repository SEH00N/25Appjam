using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour
{
    [SerializeField]
    private Material[] skyMat;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SkyChange();
        }
    }

    public void SkyChange()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegDown1 : MonoBehaviour
{
    public Vector3 newRotation1;
    void Update()
    {   
        //Debug.Log(legDown1Rotate);
        transform.eulerAngles = newRotation1;
    }
}

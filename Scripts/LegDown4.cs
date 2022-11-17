using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegDown4 : MonoBehaviour
{
    public Vector3 newRotation4;
    void Update()
    {
        transform.eulerAngles = newRotation4;
    }
}
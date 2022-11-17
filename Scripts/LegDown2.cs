using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegDown2 : MonoBehaviour
{
    public Vector3 newRotation2;
    void Update()
    {
        transform.eulerAngles = newRotation2;
    }
}

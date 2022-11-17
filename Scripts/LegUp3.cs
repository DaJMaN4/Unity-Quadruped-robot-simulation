using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegUp3 : MonoBehaviour
{
    public Vector3 newRotation7;
    void Update()
    {
        transform.eulerAngles = newRotation7;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegUp1 : MonoBehaviour
{
    public Vector3 newRotation5;
    void Update()
    {
        transform.eulerAngles = newRotation5;
    }
}

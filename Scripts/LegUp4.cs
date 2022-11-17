using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegUp4 : MonoBehaviour
{
    public Vector3 newRotation8;
    void Update()
    {
        transform.eulerAngles = newRotation8;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegUp2 : MonoBehaviour
{
    public Vector3 newRotation6;
    void Update()
    {
        transform.eulerAngles = newRotation6;
    }
}

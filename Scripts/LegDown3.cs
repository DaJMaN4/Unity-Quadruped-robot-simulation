using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegDown3 : MonoBehaviour
{
    public Vector3 newRotation3;
    void Update()
    {
        transform.eulerAngles = newRotation3;
    }
}

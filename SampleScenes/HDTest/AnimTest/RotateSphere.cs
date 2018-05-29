using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    public float speed = 10f;
    public bool flipRotateAxis = true;
    public GameObject go; 

    void Update()
    {
        if (go != null)
        {
            transform.RotateAround(go.transform.position, flipRotateAxis ? Vector3.up : Vector3.right, speed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }
}
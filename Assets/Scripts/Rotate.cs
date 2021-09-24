using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;
    void FixedUpdate()
    {
        transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
       // transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);
    }
}

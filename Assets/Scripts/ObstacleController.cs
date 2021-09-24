using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleController : MonoBehaviour
{
    public Vector3 target;
    public float fallSpeed;
    void Start()
    {
        target = transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        transform.localPosition = Vector3.Lerp(transform.localPosition, target, Time.deltaTime * fallSpeed);

    }



}

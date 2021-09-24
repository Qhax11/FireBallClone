using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    public GameObject target;
    Vector3 v3;
    void FixedUpdate()
    {
        v3 = new Vector3(target.transform.position.x,target.transform.position.y+7,target.transform.position.z-11);
        transform.position = v3;
    }
}

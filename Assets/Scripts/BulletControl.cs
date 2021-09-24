using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public static BulletControl Instance;
    
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    private void Awake()
    {
        Instance = this;
    }
    void FixedUpdate()
    {
       // transform.position += Vector3.forward * Time.deltaTime * 50;
        rb.velocity = new Vector3(0,0,50);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
            Transform transform = other.gameObject.transform.parent.transform;
            other.gameObject.transform.parent.GetComponent<ObstacleController>().target = new Vector3(transform.localPosition.x, transform.localPosition.y - 1.5f, transform.localPosition.z);
            Destroy(gameObject);
        }

        if (other.CompareTag("Shield"))
        {           
            GameManager.Instance.GameLose();
            Destroy(gameObject);

        }
    }
}

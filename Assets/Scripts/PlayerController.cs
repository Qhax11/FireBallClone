using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public GameObject bullet;
    float delay;
    float time;
    public GameObject lastObstacle;
    public GameObject shields;
    public GameObject lastObstacle2;
    public GameObject shields2;
    public float speed = 0;
    bool lastObstacleBool = true;
    bool lastObstacleBool2 = true;
    public bool canShoot = true;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && canShoot)
        {
            time += Time.deltaTime;

            // let him shoot every 0.2 seconds
            if (delay <= time) 
            {
                BullitMaker();
                delay += 0.2f;
            }         
        }
        if (Input.GetMouseButtonUp(0))
        {
            time = 0;
            delay = 0;
        }

        if (lastObstacle == null && lastObstacleBool)
        {
            speed = 10;
            LastObstacle(shields);
            lastObstacleBool = false;
        }
        else if (lastObstacle2 == null && lastObstacleBool2)
        {
            LastObstacle(shields2);
            GameManager.Instance.GameWin();
            lastObstacleBool2 = false;
        }

    }

    private void FixedUpdate()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zone"))
        {
            speed = 0;
            canShoot = true;
        }
    }
    void BullitMaker()
    {
        Vector3 v3 = new Vector3(transform.position.x,transform.position.y+0.5f,transform.position.z+1.5f);
        Instantiate(bullet,v3,Quaternion.identity,GameObject.Find("Bullets").transform);
       
    }

    void LastObstacle(GameObject shields)
    {
        GameManager.Instance.DestroyBulletOnScene();
        canShoot = false;
        Destroy(shields);
    }
}

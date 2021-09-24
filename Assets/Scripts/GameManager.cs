using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject shields;
    public GameObject shields2;
    public GameObject obstacles;
    public GameObject obstacles2;
    public GameObject bullets;

    private void Awake()
    {
        Instance = this;
    }

    public void GameLose()
    {
        Destroy(shields);
        Destroy(shields2);
        obstacles.GetComponent<Rotate>().enabled = false;
        obstacles2.GetComponent<Rotate>().enabled = false;
        PlayerController.Instance.canShoot = false;
        DestroyBulletOnScene();
        UIManager.Instance.GameLose();
    }

    public void GameWin()
    {
        DestroyBulletOnScene();
        UIManager.Instance.GameWin();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void DestroyBulletOnScene()
    {
        for(int i=0; i < bullets.transform.childCount; i++)
        {
            Destroy(bullets.transform.GetChild(i).gameObject);
        }
    }
}

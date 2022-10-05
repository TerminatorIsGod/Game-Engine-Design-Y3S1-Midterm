using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{

    ScoreManager scoreManager;
    float baseSpeed = 1.0f;
    float speed = 1;

    bool spawningCat = false;

    public GameObject catPrefab;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = ScoreManager._instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawningCat)
        {
            Invoke("spawnCat", 1/speed);
            spawningCat = true;
        }
    }

    void spawnCat()
    {
        Instantiate(catPrefab);
        speed = baseSpeed + (scoreManager.score / 5);
        spawningCat = false;
    }
}

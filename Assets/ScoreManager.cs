using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    static public ScoreManager _instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (!_instance)
        {
            Debug.Log("instance doesn't exit already");
            _instance = this;
        } else
        {
            Debug.Log("instance does exit already");
            Destroy(this.gameObject);
        }
    }

    public float score = 0;
    public int displayScore;

    // Update is called once per frame
    void Update()
    {
        score += (1 * Time.deltaTime);
        displayScore = (int)score;
    }
}

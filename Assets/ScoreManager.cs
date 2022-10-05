using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    static public ScoreManager _instance;
    public Observee observee;

    public GameObject spikePrefab;

    public float score = 0;
    public int displayScore;

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

        observee = new Observee();
    }

    private void Start()
    {
        GameObject spikeObj = Instantiate(spikePrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
        Spike spike = new Spike(spikeObj, 1);
        observee.AddObserver(spike);
    }

    // Update is called once per frame
    void Update()
    {
        score += (1 * Time.deltaTime);
        displayScore = (int)score;

        if (((displayScore % 10) == 0) && (displayScore > 5))
        {
            observee.Notify();
        }
    }
}

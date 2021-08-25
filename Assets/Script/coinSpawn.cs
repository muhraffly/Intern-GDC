using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawn : MonoBehaviour
{
    public GameObject coins;
    public float timeToSpawn = .5f;
    private float currentTimeToSpawn;
    private int coinCount;
    public obstaclesSpawn spawner;
    // Start is called before the first frame update
    void Start()
    {

    }

    void spawnCoin()
    {
        Instantiate(coins, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerCoin();
    }

    private void UpdateTimerCoin()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            spawnCoin();
            currentTimeToSpawn = timeToSpawn;
        }
    }
}

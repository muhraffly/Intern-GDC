using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesSpawn : MonoBehaviour
{
    public float waktuMin, waktuMax;
    public List<GameObject> obstacles = new List<GameObject>();
    public bool isRandomized;
    public float timeToSpawn = 2f;
    private float currentTimeToSpawn;
    private float obstacleCount = 0f;
    public bool canSpawnCoin = true;
    // public float Yobstacle;
    // public float kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        // kecepatan = 0.020f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
            canSpawnCoin = true;
        }
        else
        {
            SpawnObject();
            canSpawnCoin = false;
            obstacleCount += 1f;
            if(obstacleCount % 3f == 0f && obstacleCount <= 21f && obstacleCount != 0f){
                timeToSpawn -= .2f;
            }
            currentTimeToSpawn = timeToSpawn;
        }
        canSpawnCoin = true;
    }

    public void SpawnObject()
    {
        int index = isRandomized ? Random.Range(0, obstacles.Count) : 0;
        
        if(obstacles.Count > 0){
            Instantiate(obstacles[index], obstacles[index].transform.position, transform.rotation);
            // Yobstacle = obstacles[index].transform.position.y;
        }
    }
}

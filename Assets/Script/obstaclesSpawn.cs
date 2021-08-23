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
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        else
        {
            SpawnObject();
            obstacleCount += 1f;
            if(obstacleCount % 3f == 0f && obstacleCount <= 18f && obstacleCount != 0f){
                timeToSpawn -= .2f;
            }
            currentTimeToSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {
        int index = isRandomized ? Random.Range(0, obstacles.Count) : 0;
        
        if(obstacles.Count > 0){
            Instantiate(obstacles[index], transform.position, transform.rotation);
        }
    }
}

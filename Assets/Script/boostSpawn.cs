using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostSpawn : MonoBehaviour
{
    public GameObject objek;
    public float timeToSpawn = .5f;
    private float currentTimeToSpawn;
    public obstaclesSpawn spawner;
    // Start is called before the first frame update
    void Start()
    {

    }

    void spawnObject()
    {
        Instantiate(objek, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerBoost();
    }

    private void UpdateTimerBoost()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            spawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }
}

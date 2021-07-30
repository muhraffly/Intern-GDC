using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesSpawn : MonoBehaviour
{
    public GameObject obstacles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void copy()
    {
        Instantiate(obstacles, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawn : MonoBehaviour
{
    public GameObject coins;
    // Start is called before the first frame update
    void Start()
    {

    }

    void copy()
    {
        Instantiate(coins, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

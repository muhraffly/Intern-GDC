using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBackground : MonoBehaviour
{
    public GameObject bg;
    public float posisi;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnbg());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnbg()
    {
        Instantiate(bg, transform.position + Vector3.right * posisi, Quaternion.identity);
        yield return new WaitForSeconds(2);
        StartCoroutine(spawnbg());

    }
}

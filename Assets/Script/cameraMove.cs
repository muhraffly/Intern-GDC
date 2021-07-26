using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject player;
    public float jarak;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posx = new Vector3(player.transform.localPosition.x + (player.transform.localScale.x * jarak), 0, -10f);
        transform.localPosition = Vector3.Slerp(transform.localPosition, posx, 0.01f);
    }
}

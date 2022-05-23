using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public Vector3 mover;
    public float xSpeed;
    public float xLimitRight;
    public float xLeftLimit;
    public bool toRight;

    public GameObject prefab1;
    public GameObject prefab2;

    void Start()
    {
        toRight = true;
    }

    void Update()
    {
        
        if (toRight == true)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x > xLimitRight)
        {
            toRight = false;
            Instantiate(prefab1);
        }
        else if(transform.position.x < xLeftLimit)
        {
            toRight = true;
            Instantiate(prefab2);
        }
       
    }
}

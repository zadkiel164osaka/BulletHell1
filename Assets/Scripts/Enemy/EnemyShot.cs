using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject bullet;
    public float DelayTime = 3;
    float currentTime = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentTime >= DelayTime)
        {
            currentTime = 0;
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
        else
        {
            currentTime += Time.deltaTime;
        }
    }

}   

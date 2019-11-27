using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    public float DelayTime = 3;
    float currentTime = 0;
    public GameObject ShootPosition;
    public Rigidbody2D mybody;
    [SerializeField]//Nếu dùng private thì e dùng cái này phía trên biến là có thể conffig ở ngoài inspector
    private Transform[] ShootPositions;


    void Start()
    {
        
    }

    void Update()
    {
        mybody.velocity = transform.up * speed;

        for (int i = 0; i <= 360; i += 15)
        {
            Instantiate(bullet, ShootPositions[0].position, Quaternion.Euler(0, 0, i));
        }
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

    void RolateSpaceShip(Vector3 target)
    {
        Vector3 dir = target - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

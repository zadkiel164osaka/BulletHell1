using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarisaBullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D mybody;
    // Start is called before the first frame update
    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        mybody.velocity = transform.up * speed ;
            
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            Destroy(target.gameObject);
            Destroy(this.gameObject);
        }
        if (target.tag == "Limitbox")
        {
            Destroy(this.gameObject);
        }
    }
}


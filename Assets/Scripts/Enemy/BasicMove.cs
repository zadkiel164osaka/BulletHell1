using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    public float EnemySpeed;
    private Rigidbody2D myBody;

    // Start is called before the first frame update

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
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
        myBody.velocity = new Vector2(0f, -EnemySpeed);
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {

            Destroy(target.gameObject);
            GamePlayControl.instance.DestroyedPlayer();
        }
        if (target.tag == "Limitbox")
        {
            Destroy(this.gameObject);
        }

        //if (target.tag == "PlayerBullet")
       // {
        //    Hp--;
       //     if (Hp <= 0)
       //     {
      //          Destroy(this.gameObject);
       //     }

      //  }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : MonoBehaviour
{
    public float Speed;
    public float Despawn;
    void Update()
    {
        transform.Translate(Vector3.right * Speed);
        Destroy(this.gameObject, Despawn);
        
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);
            Destroy(this.gameObject);
            GamePlayControl.instance.DestroyedPlayer();
        }
        if (target.tag == "Limitbox")
        {
            Destroy(this.gameObject);
        }
    }

}

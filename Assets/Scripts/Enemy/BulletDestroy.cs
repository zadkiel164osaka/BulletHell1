using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    // Start is called before the first frame update
   
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(target.gameObject);
            GamePlayControl.instance.DestroyedPlayer();
        }
        if (target.tag == "Limitbox")
        {
            Destroy(this.gameObject);
        }
    }
}

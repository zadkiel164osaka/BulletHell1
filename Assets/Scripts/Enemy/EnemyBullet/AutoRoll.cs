using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRoll : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D myBody;
    public float RollSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, RollSpeed);
    }
}

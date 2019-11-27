using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float Speed;
    private Material mat;
    private Vector2 offset = Vector2.zero;
    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }
    // Start is called before the first frame update
    void Start()
    {
        //offset = mat.GetTextureOffset("_Maintex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.y += Speed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
    }
}

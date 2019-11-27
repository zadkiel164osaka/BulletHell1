using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitToScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var ChieuDai = Camera.main.orthographicSize * 3f;
        // Debug.Log(ChieuDai=10 );

        var ChieuRong = ChieuDai * Screen.width / Screen.height;
        transform.localScale = new Vector3(ChieuDai, ChieuRong, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

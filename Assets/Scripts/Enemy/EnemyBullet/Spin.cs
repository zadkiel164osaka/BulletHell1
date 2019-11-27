using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float SpinSpeed;
    public GameObject bullet;
    public GameObject Spinner1;
    public GameObject Spinner2;
    public GameObject Spinner3;
    public GameObject Spinner4;
    public GameObject Spinner5;
    public GameObject Spinner6;
    public GameObject Spinner7;
    public GameObject Spinner8;
    public GameObject Spinner9;
    public GameObject Spinner10;
    public GameObject Spinner11;
    public GameObject Spinner12;

    public float Timer1 = 0.15f;
    void Update()
    {
        Timer1 -= Time.deltaTime;
        if (Timer1 <= 0f)
        {
            Instantiate(bullet, Spinner1.transform.position, Spinner1.transform.rotation);
            Instantiate(bullet, Spinner2.transform.position, Spinner2.transform.rotation);
            Instantiate(bullet, Spinner3.transform.position, Spinner3.transform.rotation);
            Instantiate(bullet, Spinner4.transform.position, Spinner4.transform.rotation);
            Instantiate(bullet, Spinner5.transform.position, Spinner5.transform.rotation);
            Instantiate(bullet, Spinner6.transform.position, Spinner6.transform.rotation);
            Instantiate(bullet, Spinner7.transform.position, Spinner7.transform.rotation);
            Instantiate(bullet, Spinner8.transform.position, Spinner8.transform.rotation);
            Instantiate(bullet, Spinner9.transform.position, Spinner9.transform.rotation);
            Instantiate(bullet, Spinner10.transform.position, Spinner10.transform.rotation);
            Instantiate(bullet, Spinner11.transform.position, Spinner11.transform.rotation);
            Instantiate(bullet, Spinner12.transform.position, Spinner12.transform.rotation);
            Timer1 = 0.15f;
        }
        transform.Rotate(Vector3.forward * SpinSpeed * Time.deltaTime);
        

    }

}

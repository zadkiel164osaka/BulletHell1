using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D myBody;
    public GameObject Bullet;
    
    [SerializeField]//Nếu dùng private thì e dùng cái này phía trên biến là có thể conffig ở ngoài inspector
    private Transform []ShootPositions;
    public float ShootingTime = 0.25f;
    float currentTime = 0;
    AudioSource AudioSource;
    [SerializeField]
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
        if (Input.GetKey("z") && currentTime >= ShootingTime)
        {
            currentTime = 0;
            //AudioSource.Play(
            //Bắn 2 đạn
            for (int i = 0; i< ShootPositions.Length;i++)
            {
              
                Instantiate(Bullet, ShootPositions[i].position, ShootPositions[i].rotation);
              
            }
    
             
            //Bắn đủ thứ hướng
            //for (int i = 0; i <= 360; i+= 15)//15 là sốc góc, 360 là góc tối đa
            //{
            // thì chỗ I này
            //    Instantiate(Bullet, ShootPositions[0].position, Quaternion.Euler(0,0,i));
            //}
            // int Góc bắn = 0;
            // ví dụ số đạn  = 10
            // float  Góc mỗi viên = 90/10
            //for (int i = 0; i < số đạn; i++)
            //{
            //  Instantiate(<Loại đạn bắn>, <vị trí đạn được tạo ra>, Quaternion.Euler(0,0,<góc bắn>));
            //  Góc bắn += Góc mỗi viênth
            //}
            //Instantiate(Bullet, ShootPositions[2].position, Quaternion.identity);
        }
        currentTime += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        
        float xAxis = Input.GetAxisRaw("Horizontal") * Speed;
        float yAxis = Input.GetAxisRaw("Vertical") * Speed;
        myBody.velocity = new Vector2(xAxis, yAxis);

        
    }
        
}

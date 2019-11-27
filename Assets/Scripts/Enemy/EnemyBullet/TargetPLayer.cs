using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPLayer : MonoBehaviour
{
    public float speed;
    public Rigidbody2D mybody;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        //Ta lấy vị trí hiện tại của player làm mục tiêu

        //Nếu muốn đan luôn theo player khi player thay đổi mỗi frame thì cho vào update
        //ok 
        //Cái này chỉ di chuển tới vị trí player là nó đứng im ko đi nữa
       
        //Cách này dùng khi e muốn di tới thẳng mục tiêu or theo mục tiêu đến khi biến mất
        target = GameObject.FindGameObjectWithTag("Player").transform.position;
        //Cách 2 là xoay hướng đạn hướng về player
        RolateSpaceShip(target);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, target, speed);

        //Cách 2
        mybody.velocity = transform.up * speed; // tí tự thêm rigidbody nhé
    }
    // Này dùn để xoay vật thể theo hướng 1 mục tiêu nào đó. e truyền target = vị trí player là được
    // Giải thích hàm này thì e xem cái gì giữa  2vector quên r, đợi a ti
    //Xong e áp dụng cái này cho nó là đc
    void RolateSpaceShip(Vector3 target)
    {
        Vector3 dir = target - transform.position ;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

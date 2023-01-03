using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveController : MonoBehaviour
{
    public float movementSpeed;
    Vector3 movement = new Vector3();
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame


    /*private void FixedUpdate()
    {
        //movement.x += 1;
        movement.y += 1;

        movement.Normalize();
        m_Rigidbody.MovePosition(transform.position + movement * movementSpeed);
    }*/
    int objSize = 3;
    float circleR; //반지름
    float deg; //각도
    float objSpeed; //원운동 속도

    void Update()
    {
        while (true)
        {
            for (int th = 0; th < 360; th++)
            {
                var rad = Mathf.Deg2Rad * th;
                var x = circleR * Mathf.Sin(rad);
                var y = circleR * Mathf.Cos(rad);
                this.transform.position = transform.position + new Vector3(x, y);
                this.transform.rotation = Quaternion.Euler(0, 0, (deg + (th * (360 / objSize))) * -1);
            }
        }
    }
}

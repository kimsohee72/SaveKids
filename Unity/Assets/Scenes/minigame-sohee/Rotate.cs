using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        baby.transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject table;       //기준
    public GameObject baby;
    public float speed;             //회전 속도

    void OrbitAround()
    {
        
        transform.RotateAround(table.transform.position, Vector3.up, speed * Time.deltaTime);
        
    }

    private void FixedUpdate()
    {
        OrbitAround();
    }
    // RotateAround(Vector3 point, Vector3 axis, float angle)
}


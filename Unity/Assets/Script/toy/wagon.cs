using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wagon : MonoBehaviour
{
    public GameManager gameManager;
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int near_num, num, house;
    Transform target;
    public GameObject Wagon;
    public AudioSource setting;    

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);

        near_num = LayerMask.NameToLayer("near");
        num = LayerMask.NameToLayer("waiting");
        house = LayerMask.NameToLayer("House");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        //Debug.Log(rigid.position);

        if (Physics.Raycast(ray, 0.1f, 1 << near_num))
        {
            gameManager.wagon = true;
            setting.Play();

        }
        else if (Physics.Raycast(ray, 0.1f, 1 << num))
        {
            //Debug.Log("waiting");
            target = Wagon.GetComponent<Transform>();
            target.position = new Vector3(-4.35f, 0.05f, 9.32f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.1f, 1 << house))
        {
            gameManager.wagon = false;
            setting.Play();
        }
        else if(rigid.position.y < -1.0f)
        {
            target = Wagon.GetComponent<Transform>();
            target.position = new Vector3(-4.35f, 0.05f, 9.32f);
            target.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

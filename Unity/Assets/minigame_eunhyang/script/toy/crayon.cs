using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class crayon : MonoBehaviour
{
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int high;
    TMP_Text list;
    public GameObject text;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            list = GameObject.Find("list_crayon").GetComponent<TextMeshPro>();
    }

    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);
        high = LayerMask.NameToLayer("high");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        if (Physics.Raycast(ray, 0.01f, 1 << high))
        {
            //Debug.Log("high");
            list.text = "작은 크레파스";
            list.color = new Color(0, 0, 0, 1);
        }
    }
}

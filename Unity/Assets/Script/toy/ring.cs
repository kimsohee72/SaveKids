using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ring : MonoBehaviour
{
    public GameManager gameManager;
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int near_num, num;
    TMP_Text list;
    public GameObject text;
    Transform target;
    public GameObject Ring;
    public AudioSource setting;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            list = GameObject.Find("list_ring").GetComponent<TextMeshPro>();
    }
    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);

        near_num = LayerMask.NameToLayer("near");
        num = LayerMask.NameToLayer("waiting");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        //Debug.Log(rigid.position);

        if (Physics.Raycast(ray, 0.05f, 1 << near_num))
        {
            //Debug.Log("good");
            gameManager.ring = true;
            list.text = "반지";
            list.color = new Color(0, 0, 0, 1);
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.1f, 1 << num))
        {
            Debug.Log("waiting");
            target = Ring.GetComponent<Transform>();
            target.position = new Vector3(-3.19f, 0.06f, 11.60f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
    }
}

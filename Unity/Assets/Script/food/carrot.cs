using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class carrot : MonoBehaviour
{
    public GameManager gameManager;
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int near_num, far_num, house;
    TMP_Text info;
    public GameObject Carrot;
    public GameObject text;
    Transform target;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            info = GameObject.Find("list_carrot").GetComponent<TextMeshPro>();
    }
    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);

        near_num = LayerMask.NameToLayer("near");
        far_num = LayerMask.NameToLayer("far");
        house = LayerMask.NameToLayer("House");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        //Debug.Log(rigid.position);

        if (Physics.Raycast(ray, 0.0001f, 1 << near_num))
        {
            //Debug.Log("near");
            info.text = "���";
            info.color = new Color(1, 0, 0, 1);
        }
        else if (Physics.Raycast(ray, 0.0001f, 1 << far_num))
        {
            //Debug.Log("far");
            info.text = "���";
            info.color = new Color(0, 0, 1, 1);
            gameManager.carrot = true;
            Carrot.GetComponent<XRGrabInteractable>().enabled = false;
        }
        else if (Physics.Raycast(ray, 0.1f, 1 << house))
        {
            target = Carrot.GetComponent<Transform>();
            target.position = new Vector3(-3.57f, 1.00f, 1.21f);
            target.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}

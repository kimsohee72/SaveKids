using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class stacker : MonoBehaviour
{
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int low;
    TMP_Text list;
    public GameObject text;
    public GameObject Stacker;
    public GameManager gameManager;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            list = GameObject.Find("list_stacker").GetComponent<TextMeshPro>();
    }

    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);
        low = LayerMask.NameToLayer("low");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        if (Physics.Raycast(ray, 0.5f, 1 << low))
        {
            //Debug.Log("low");
            list.text = "링 스태커";
            list.color = new Color(0, 0, 0, 1);

            gameManager.stacker = true;
            Stacker.GetComponent<XRGrabInteractable>().enabled = false;
        }
    }
}

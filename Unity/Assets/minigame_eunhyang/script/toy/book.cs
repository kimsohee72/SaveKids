using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class book : MonoBehaviour
{
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int low;
    TMP_Text list;
    public GameObject text;
    public GameManager gameManager;
    public GameObject Book;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            list = GameObject.Find("list_book").GetComponent<TextMeshPro>();
    }

    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);
        low = LayerMask.NameToLayer("low");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        if (Physics.Raycast(ray, 0.1f, 1 << low))
        {
            //Debug.Log("low");
            list.text = "책";
            list.color = new Color(0, 0, 0, 1);

            gameManager.book = true;
           
            Book.GetComponent<XRGrabInteractable>().enabled = false;
        }
    }
}

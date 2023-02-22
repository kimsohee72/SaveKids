using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class chessgame : MonoBehaviour
{
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int high;
    TMP_Text list;
    public GameObject text;
    public GameManager gameManager;
    public GameObject Chessgame;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            list = GameObject.Find("list_chessgame").GetComponent<TextMeshPro>();
    }

    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);
        high = LayerMask.NameToLayer("high");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        if (Physics.Raycast(ray, 0.5f, 1 << high))
        {
            //Debug.Log("high");
            list.text = "체스";
            list.color = new Color(0, 0, 0, 1);

            gameManager.chessgame = true;
          
            Chessgame.GetComponent<XRGrabInteractable>().enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class banana : MonoBehaviour
{
    public GameManager gameManager;
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int near_num, far_num, house, num;
    TMP_Text info;
    public GameObject Banana;
    public GameObject text;
    Transform target;
    public AudioSource setting;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            info = GameObject.Find("list_banana").GetComponent<TextMeshPro>();
    }
    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down);

        near_num = LayerMask.NameToLayer("near");
        far_num = LayerMask.NameToLayer("far");
        house = LayerMask.NameToLayer("House");
        num = LayerMask.NameToLayer("waiting");
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0));

        //Debug.Log(rigid.position);

        if (Physics.Raycast(ray, 0.03f, 1 << near_num))
        {
            //Debug.Log("near");
            info.text = "바나나";
            info.color = new Color(0, 0, 1, 1);
            gameManager.banana = true;
            Banana.GetComponent<XRGrabInteractable>().enabled = false;
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.03f, 1 << far_num))
        {
            //Debug.Log("far");
            info.text = "바나나";
            info.color = new Color(1, 0, 0, 1);
            setting.Play();
        }
        else if(Physics.Raycast(ray,0.5f, 1 << house))
        {
            target = Banana.GetComponent<Transform>();
            target.position = new Vector3(-3.13f, 1.00f, 1.00f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.03f, 1 << num))
        {
            target = Banana.GetComponent<Transform>();
            target.position = new Vector3(-3.13f, 1.00f, 1.00f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
        else
        {
            target = Banana.GetComponent<Transform>();
            target.position = new Vector3(-3.13f, 1.00f, 1.00f);
            target.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

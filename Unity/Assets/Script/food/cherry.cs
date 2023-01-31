using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class cherry : MonoBehaviour
{
    public GameManager gameManager;
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int near_num, far_num, house, num;
    TMP_Text info;
    public GameObject Cherry;
    public GameObject text;
    Transform target;
    public AudioSource setting;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            info = GameObject.Find("list_cherry").GetComponent<TextMeshPro>();
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

        if (Physics.Raycast(ray, 0.001f, 1 << near_num))
        {
            //Debug.Log("near");
            info.text = "체리";
            info.color = new Color(1, 0, 0, 1);
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.001f, 1 << far_num))
        {
            //Debug.Log("far");
            info.text = "체리";
            info.color = new Color(0, 0, 1, 1);
            gameManager.cherry = true;
            Cherry.GetComponent<XRGrabInteractable>().enabled = false;
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.05f, 1 << house))
        {
            target = Cherry.GetComponent<Transform>();
            target.position = new Vector3(-2.91f, 1.00f, 1.02f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.05f, 1 << num))
        {
            target = Cherry.GetComponent<Transform>();
            target.position = new Vector3(-2.91f, 1.00f, 1.02f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
        else
        {
            target = Cherry.GetComponent<Transform>();
            target.position = new Vector3(-2.91f, 1.00f, 1.02f);
            target.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

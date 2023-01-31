using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class beef : MonoBehaviour
{
    public GameManager gameManager;
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int near_num, far_num, house, num;
    TMP_Text info;
    public GameObject Beef;
    public GameObject text;
    Transform target;
    public AudioSource setting;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            info = GameObject.Find("list_beef").GetComponent<TextMeshPro>();
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

        if (Physics.Raycast(ray, 0.01f, 1 << near_num))
        {
            //Debug.Log("near");
            info.text = "고기 조각";
            info.color = new Color(1, 0, 0, 1);
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.01f, 1 << far_num))
        {
            //Debug.Log("far");
            info.text = "고기 조각";
            info.color = new Color(0, 0, 1, 1);
            gameManager.beef = true;
            Beef.GetComponent<XRGrabInteractable>().enabled = false;
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.1f, 1 << house))
        {
            target = Beef.GetComponent<Transform>();
            target.position = new Vector3(-2.70f, 1.00f, 1.05f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.1f, 1 << num))
        {
            target = Beef.GetComponent<Transform>();
            target.position = new Vector3(-2.70f, 1.00f, 1.05f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
        else if (rigid.position.y < 0)
        {
            target = Beef.GetComponent<Transform>();
            target.position = new Vector3(-2.70f, 1.00f, 1.05f);
            target.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

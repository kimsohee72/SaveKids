using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class coin : MonoBehaviour
{
    public GameManager gameManager;
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int near_num, num, house;
    TMP_Text list;
    public GameObject text;
    Transform target;
    public GameObject Coin;
    public AudioSource setting;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            list = GameObject.Find("list_coin").GetComponent<TextMeshPro>();
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
            //Debug.Log("good");
            gameManager.coin = true;
            list.text = "동전";
            list.color = new Color(0, 0, 0, 1);
            Coin.GetComponent<XRGrabInteractable>().enabled = false;
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.1f, 1 << num))
        {
            Debug.Log("waiting");
            target = Coin.GetComponent<Transform>();
            target.position = new Vector3(-2.58f, 0.04f, 8.94f);
            target.rotation = Quaternion.Euler(0, 0, 0);
            setting.Play();
        }
        else if (Physics.Raycast(ray, 0.1f, 1 << house))
        {
            setting.Play();
        }
        else if (rigid.position.y < -1.0f)
        {
            target = Coin.GetComponent<Transform>();
            target.position = new Vector3(-2.58f, 0.04f, 8.94f);
            target.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

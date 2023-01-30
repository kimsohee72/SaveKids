using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{
    Rigidbody rigid;
    public LayerMask worldLayer;
    Ray ray;
    int low;
    TMP_Text list;
    public GameObject text;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (text.activeSelf == true)
            list = GameObject.Find("list_ball").GetComponent<TextMeshPro>(); // list_ball�� ������ text �ν�
    }

    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down); // ��ü�� �ٴڸ� �߾� �������� ray ����
        low = LayerMask.NameToLayer("low"); // low��� ������ layer�� low��� ������ �Ҵ�
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0)); // ray Ȯ���� ���� ���� ���� �� scene ȭ�鿡�� ray�� ���̰� �ص�

        if (Physics.Raycast(ray, 0.5f, 1 << low)) // ray�� low ���̾ �ε����� ��
        {
            //Debug.Log("low");
            list.text = "��";
            list.color = new Color(0, 0, 0, 1);
        }
    }
}

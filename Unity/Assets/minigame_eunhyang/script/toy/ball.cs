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
            list = GameObject.Find("list_ball").GetComponent<TextMeshPro>(); // list_ball로 만들어둔 text 인식
    }

    void Update()
    {
        ray = new Ray(rigid.position, Vector3.down); // 물체의 바닥면 중앙 기준으로 ray 생성
        low = LayerMask.NameToLayer("low"); // low라고 만들어둔 layer를 low라는 변수에 할당
    }

    void FixedUpdate()
    {
        Debug.DrawRay(rigid.position, Vector3.down * 0.1f, new Color(0, 1, 0)); // ray 확인을 위해 게임 실행 시 scene 화면에서 ray가 보이게 해둠

        if (Physics.Raycast(ray, 0.5f, 1 << low)) // ray가 low 레이어에 부딪혔을 때
        {
            //Debug.Log("low");
            list.text = "공";
            list.color = new Color(0, 0, 0, 1);
        }
    }
}

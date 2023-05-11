using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoA_HandChange : MonoBehaviour
{
    public GameObject SoA_Nurse;
    public GameObject SoA_R_hand;
    public GameObject SoA_L_hand;
    public GameObject SoA_Baby;
    public GameObject SoA_Baby_Attach;

    Transform target_Baby_attach;
    Transform target_Nurse;

    Animator SoA_Nurse_animator;

    int change = 0;

    bool scene1 = false;
    bool scene2 = false;
    bool scene3 = false;
    bool scene4 = false;

    // Start is called before the first frame update
    void Start()
    {
        SoA_R_hand.SetActive(false);
        SoA_L_hand.SetActive(true);

        target_Baby_attach = SoA_Baby_Attach.GetComponent<Transform>();

        SoA_Nurse_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 간호사의 위치가 계속 내려가고 자꾸 시계 방향으로 회전하는 것을 막음
        target_Nurse = SoA_Nurse.GetComponent<Transform>();
        target_Nurse.position = new Vector3(0, -1f, 0);
        target_Nurse.rotation = Quaternion.Euler(0, 90, 0);

        // 아기의 위치 변화
        if(scene1 == false && scene2 == false && scene3 == false && scene4 == false)
		{
            if (SoA_Nurse_animator.GetCurrentAnimatorStateInfo(0).IsName("scene0") &&
                SoA_Nurse_animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                SoA_Nurse_animator.SetBool("1", true);
                SoA_Nurse_animator.SetBool("5", false);
                scene1 = true;
            }
		}

        if (scene1 == true)
        {
            target_Nurse.position = new Vector3(0, 0, 0);
            if (SoA_Nurse_animator.GetCurrentAnimatorStateInfo(0).IsName("scene1") &&
                SoA_Nurse_animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                SoA_Nurse_animator.SetBool("1", false);
                SoA_Nurse_animator.SetBool("2", true);
                SoA_Nurse_animator.SetBool("5", false);
                scene2 = true;
            }
        }

        if (scene2 == true)
        {
            AttachTransform();
            if (SoA_Nurse_animator.GetCurrentAnimatorStateInfo(0).IsName("scene2") &&
                SoA_Nurse_animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                SoA_Nurse_animator.SetBool("2", false);
                SoA_Nurse_animator.SetBool("3", true);
                SoA_Nurse_animator.SetBool("5", false);
                scene3 = true;
            }
        }

        if (scene3 == true)
        {
            target_Nurse.position = new Vector3(0, 0, 0);
            if (SoA_Nurse_animator.GetCurrentAnimatorStateInfo(0).IsName("scene3") &&
                SoA_Nurse_animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                SoA_Nurse_animator.SetBool("3", false);
                SoA_Nurse_animator.SetBool("4", true);
                SoA_Nurse_animator.SetBool("5", false);
                scene4 = true;
            }
        }

        if (scene4 == true)
        {
            target_Nurse.position = new Vector3(0, 0, 0);
            SoA_Nurse_animator.SetBool("4", false);
            SoA_Nurse_animator.SetBool("5", false);
        }
    }

    void AttachTransform()
	{
        if(change == 0)
		{
            target_Baby_attach.rotation = Quaternion.Euler(180, 100, -100);
            change += 1;
		}
    }
}

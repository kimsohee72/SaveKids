using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class babyAction : MonoBehaviour
{
    public Animator animator;

    public bool startTimer = false;
    public float timeElapsed = 0;

    public bool notCryingStartTimer = false;
    public float notCryingTimeElapsed = 0;

    public bool isCrying = true;
    public bool isEating = false;

    public int checkEat = 0;

    public GameObject panelEnd;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;

    bool warning = false;
    public float warningTimeElapsed = 0;

    public int babySounding = 0; // 0 : start, 1 : crying, 2 : amazed, 3 : eating, 4 : happy

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.A) && startTimer == false)
        {
            animator.SetBool("isEating", false);
            timeElapsed = 0;
            startTimer = true;
            Debug.Log("a start");
        }
        

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (startTimer == true)
            {
                startTimer = false;
            }
        }
        */

        if (startTimer == true)
        {
            timeElapsed += UnityEngine.Time.deltaTime;
        }
        else if(notCryingStartTimer == true)
        {
            notCryingTimeElapsed += UnityEngine.Time.deltaTime;
        }

        if (timeElapsed > 2.0 && startTimer == true)
        {
            timeElapsed = 0.0f;
            startTimer = false;

            notCryingStartTimer = true;
            notCryingTimeElapsed = 0;

            isCrying = false;
            animator.SetBool("isCrying", isCrying);
        }

        if (notCryingTimeElapsed > 20.0 && notCryingStartTimer == true)
        {
            notCryingStartTimer = false;
            notCryingTimeElapsed = 0.0f;

            isCrying = true;
            animator.SetBool("isCrying", isCrying);
        }

        if (isEating == true)//&& iscrying true
        {
            notCryingStartTimer = false;
            notCryingTimeElapsed = 0.0f;

            isCrying = false;
            animator.SetBool("isEating", isEating);

            animator.SetBool("isCrying", isCrying);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("End"))
        {
            panelEnd.SetActive(true);
        }

        if (warning == true)
        {
            warningTimeElapsed += UnityEngine.Time.deltaTime;
        }

        if(warningTimeElapsed>3.0f && warning == true)
        {
            warningTimeElapsed = 0.0f;
            warning = false;
        }

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("sit_idle4")
            || animator.GetCurrentAnimatorStateInfo(0).IsName("sit_laugh"))
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(false);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("sit_idle_amazed"))
        {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(true);
            panel4.SetActive(false);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("sit_cry") && warning == false && GameObject.Find("BabyRattle_01").GetComponent<rattleShake>().isGrabbing==false)
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(false);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Spoon" && isEating == false && isCrying == false)
        {
            Debug.Log(checkEat);
            isCrying = false;
            isEating = true;
            checkEat++;
            animator.SetInteger("countEat", checkEat);
        }
        else if(other.name == "Spoon" && isCrying == true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("sit_cry"))
            {
                warning = true;
                panel1.SetActive(false);
                panel2.SetActive(false);
                panel3.SetActive(false);
                panel4.SetActive(true);
            }
        }
    }
}

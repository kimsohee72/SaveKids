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
         //   Debug.Log(timeElapsed + "\n");
        }
        else if(notCryingStartTimer == true)
        {
            notCryingTimeElapsed += UnityEngine.Time.deltaTime;

         //   Debug.Log(notCryingTimeElapsed + "\n");
            
        }

        if (timeElapsed > 2.0 && startTimer == true)
        {
            startTimer = false;
            Debug.Log(timeElapsed);

            notCryingStartTimer = true;
            notCryingTimeElapsed = 0;
            Debug.Log("bstart");

            isCrying = false;
            animator.SetBool("isCrying", isCrying);

            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(true);
        }

        if (notCryingTimeElapsed > 20.0 && notCryingStartTimer == true)
        {
            notCryingStartTimer = false;
            Debug.Log(notCryingTimeElapsed);

            isCrying = true;
            animator.SetBool("isCrying", isCrying);

            panel1.SetActive(true);
            panel2.SetActive(false);
            panel3.SetActive(false);
        }

        if (isEating == true)//&& iscrying true
        {
            notCryingStartTimer = false;
            Debug.Log("bquit");

            isCrying = false;
            animator.SetBool("isEating", isEating);

            animator.SetBool("isCrying", isCrying);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("End"))
        {
            Debug.Log("adsf");
            panelEnd.SetActive(true);
        }
        /*
        if(Input.GetKeyDown(KeyCode.B) && notCryingStartTimer == true)
        {
            notCryingStartTimer = false;
            Debug.Log("bquit");

            animator.SetBool("isEating", true);

            animator.SetBool("isCrying", true);
            
        }
        */
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter : " + other.name);
        if(other.name == "Spoon" && isEating == false && isCrying == false)
        {
            Debug.Log(checkEat);
            isCrying = false;
            isEating = true;
            checkEat++;
            animator.SetInteger("countEat", checkEat);
            Debug.Log(checkEat);
        }
        else if(other.name == "Spoon" && isCrying == true)
        {
            Debug.Log("baby crying - focus on");
        }
    }
}

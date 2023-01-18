using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyAction : MonoBehaviour
{
    public Animator animator;

    public bool startTimer = false;
    public float timeElapsed = 0;

    public bool notCryingStartTimer = false;
    public float notCryingTimeElapsed = 0;

    public bool isCrying = true;
    public bool isEating = false;

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
        }

        if (notCryingTimeElapsed > 20.0 && notCryingStartTimer == true)
        {
            notCryingStartTimer = false;
            Debug.Log(notCryingTimeElapsed);

            isCrying = true;
            animator.SetBool("isCrying", isCrying);
        }

        if (isEating == true)
        {
            notCryingStartTimer = false;
            Debug.Log("bquit");

            animator.SetBool("isEating", true);

            animator.SetBool("isCrying", true);
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
        if(other.name == "Spoon_01" && isEating == false && isCrying == false)
        {
            Debug.Log("here~~~");
            isCrying = false;
            isEating = true;
        }
    }
}

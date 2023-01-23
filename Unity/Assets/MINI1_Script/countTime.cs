using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countTime : MonoBehaviour
{

    bool startTimer = false;
    float timeElapsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            timeElapsed = 0;
            startTimer = true;
        }

        if(startTimer == true)
        {
            timeElapsed += UnityEngine.Time.deltaTime;
        }

        if (timeElapsed > 2.0 && startTimer == true)
        {
            startTimer = false;
            Debug.Log(timeElapsed);
        }
    }
}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyAction : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetBool("isCrying",false);
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetBool("isCrying", true);
        }
    }
}
*/
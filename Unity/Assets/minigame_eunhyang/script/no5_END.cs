using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no5_END : MonoBehaviour
{
    public Animator animator;

    public GameObject end_menu;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("end"))
        {
            end_menu.SetActive(true);
        }
    }
    
}

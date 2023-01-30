using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab_bowl_first : MonoBehaviour
{
    Animator animator;
    public GameObject 접시클릭;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetInteger("check") == 0){
            접시클릭.SetActive(false);
        }
    }
}

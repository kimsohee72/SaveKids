using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public Animator anim;
    public GameObject lie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("lie_idle1"))
        {
            lie.transform.rotation = Quaternion.Euler(0, 0, 0);

        }
    }
}

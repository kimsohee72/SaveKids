using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socketRightToLeft : MonoBehaviour
{
    public GameObject socketLeftHand;
    public GameObject socketRightHand;
    public GameObject nurse;

    bool change = false;

    // Start is called before the first frame update
    void Start()
    {
        socketRightHand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (nurse.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("cut2"))
        {
            change = true;
        }

        if(change == true)
        {
            if (nurse.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("cut3"))
            {
                socketRightHand.SetActive(true);
                socketLeftHand.SetActive(false);
            }
        }
    }
}

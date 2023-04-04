using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nurseChangeLocation : MonoBehaviour
{
    public GameObject nurse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nurse.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("1");
        
        /*
        if (GameObject.Find("ToonBabyA").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sit_cry") &&
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding != 1)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding = 1;
            cryingAudio.Play();
        }
        */
    }
}

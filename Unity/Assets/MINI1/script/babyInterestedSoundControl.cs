using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyInterestedSoundControl : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ToonBabyA").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sit_idle_amazed") &&
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding != 2)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding = 2;
        }
    }
}

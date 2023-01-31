using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyEatingSoundControl : MonoBehaviour
{
    AudioSource eatingAudio;
    // Start is called before the first frame update
    void Start()
    {
        eatingAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ToonBabyA").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sit_idle4") && 
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding != 3)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding = 3;
            eatingAudio.Play();
        }
        else if (GameObject.Find("ToonBabyA").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sit_idle4") == false)
        {
            eatingAudio.Stop();
        }
    }
}

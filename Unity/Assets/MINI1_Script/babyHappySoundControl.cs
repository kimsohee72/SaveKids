using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyHappySoundControl : MonoBehaviour
{
    AudioSource happyAudio;
    // Start is called before the first frame update
    void Start()
    {
        happyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ToonBabyA").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sit_laugh") && 
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding != 4)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding = 4;
            happyAudio.Play();
        }
        else if (GameObject.Find("ToonBabyA").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sit_laugh") == false)
        {
            happyAudio.Stop();
        }
    }
}

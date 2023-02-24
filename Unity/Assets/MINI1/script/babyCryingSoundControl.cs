using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyCryingSoundControl : MonoBehaviour
{
    AudioSource cryingAudio;

    // Start is called before the first frame update
    void Start()
    {
        cryingAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ToonBabyA").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sit_cry") && 
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding != 1)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().babySounding = 1;
            cryingAudio.Play();
        }
        else if (GameObject.Find("ToonBabyA").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sit_cry") == false)
        {
            cryingAudio.Stop();
        }
    }
}

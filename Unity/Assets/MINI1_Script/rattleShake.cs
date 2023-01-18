using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class rattleShake : MonoBehaviour
{
    private XRGrabInteractable interactor = null;
    public bool IsGrabbing;
    
    public  AudioSource audioSource;

    public void Awake()
    {
        interactor = GetComponent<XRGrabInteractable>();
        IsGrabbing = false;

        interactor.selectEntered.AddListener(grab);
        interactor.selectExited.AddListener(ungrab);

        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.mute = false;
        audioSource.Stop();

    }

    public void OnDestroy()
    {
        ;
    }

    public void grab(BaseInteractionEventArgs arg)
    {

        audioSource.Play();
        if (GameObject.Find("ToonBabyA").GetComponent<babyAction>().startTimer == false)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().startTimer = true;
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().animator.SetBool("isEating", false);
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().timeElapsed = 0;
            Debug.Log("grab");
        }
    }
    public void ungrab(BaseInteractionEventArgs arg)
    {
        audioSource.Stop();
        if (GameObject.Find("ToonBabyA").GetComponent<babyAction>().startTimer == true)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().startTimer = false;
            Debug.Log("ungrab");
        }
    }

}

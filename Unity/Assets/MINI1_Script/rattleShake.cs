using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class rattleShake : MonoBehaviour
{
    private XRGrabInteractable interactor = null;
    
    public bool isGrabbing;
    bool audioPlaying = false;
    public  AudioSource audioSource;

    Transform rattleTransform;
    Vector3 prevLocation = new Vector3(0, 0, 0);
    Vector3 nowLocation = new Vector3(0, 0, 0);
    
    
    public void Start()
    {
        interactor = GetComponent<XRGrabInteractable>();
        isGrabbing = false;
        audioPlaying = false;

        interactor.selectEntered.AddListener(grab);
        interactor.selectExited.AddListener(ungrab);

        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.mute = false;
        audioSource.Stop();

        rattleTransform = GetComponent<Transform>();
        prevLocation = rattleTransform.position;

    }
    /*
    void Update()
    {
        if(isGrabbing == true)
        {
            nowLocation = rattleTransform.position;
            if(nowLocation.x ==prevLocation.x && nowLocation.y == prevLocation.y && nowLocation.z == prevLocation.z)
            {
                if(audioPlaying == false)
                {
                    audioPlaying = false;
                }
            }
            else
            {

            }
        }
        prevLocation = nowLocation;
    }*/

    public void OnDestroy()
    {
        ;
    }

    public void grab(BaseInteractionEventArgs arg)
    {
        isGrabbing = true;
        audioSource.Play();
        if (GameObject.Find("ToonBabyA").GetComponent<babyAction>().startTimer == false)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().isEating = false;
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().timeElapsed = 0;
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().startTimer = true;
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().animator.SetBool("isEating", GameObject.Find("ToonBabyA").GetComponent<babyAction>().isEating);
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().timeElapsed = 0;
            Debug.Log("grab");
        }
    }
    public void ungrab(BaseInteractionEventArgs arg)
    {
        isGrabbing = false;
        audioSource.Stop();
        if (GameObject.Find("ToonBabyA").GetComponent<babyAction>().startTimer == true)
        {
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().startTimer = false;
            GameObject.Find("ToonBabyA").GetComponent<babyAction>().timeElapsed = 0;
            Debug.Log("ungrab");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class rattleShake : MonoBehaviour
{
    private XRGrabInteractable interactor = null;
    
    public bool isGrabbing;
    public  AudioSource audioSource;

    Transform rattleTransform;
    Vector3 prevLocation = new Vector3(0, 0, 0);
    Vector3 nowLocation = new Vector3(0, 0, 0);

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;

    public void Start()
    {
        interactor = GetComponent<XRGrabInteractable>();
        isGrabbing = false;

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
        }
        if (GameObject.Find("ToonBabyA").GetComponent<babyAction>().notCryingStartTimer == false) {
            panel1.SetActive(false);
            panel2.SetActive(true);
            panel3.SetActive(false);
            panel4.SetActive(false);
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
        }

        if (GameObject.Find("ToonBabyA").GetComponent<babyAction>().notCryingStartTimer == false)
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(false);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;




/*
    AudioSource audioSource;
    Transform rattleTransform;

    Vector3 prevLocation = new Vector3(0, 0, 0);

    bool startTimer = false;
    float timeElapsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.mute = true;
        audioSource.Stop();

        rattleTransform = GetComponent<Transform>();

        prevLocation = rattleTransform.position;

        Debug.Log(prevLocation.x + " " + prevLocation.y + " " + prevLocation.z);

    }

    // Update is called once per frame
    void Update()
    {
        

        if (startTimer == true)
        {
            if(timeElapsed<10)
                timeElapsed += UnityEngine.Time.deltaTime;
            else
            {
                startTimer = false;
                audioSource.Stop();
            }
        }
        else
        {
            if (prevLocation.x != rattleTransform.position.x || prevLocation.y != rattleTransform.position.y || prevLocation.z != rattleTransform.position.z)
            {
                audioSource.mute = false;
                audioSource.Play();
                startTimer = true;
                timeElapsed = 0;
            }
        }

        prevLocation = rattleTransform.position;
    }
*/
/*

public class rattleGrabbed : MonoBehaviour
{
    private XRGrabInteractable interactor = null;
    public bool IsGrabbing;

   // AudioSource audioSource;


    // Start is called before the first frame update
    private void Awake()
    {
        interactor = GetComponent<XRGrabInteractable>();
        IsGrabbing = false;
        // Debug.Log(interactor);


        // audioSource = GetComponent<AudioSource>();
        // audioSource.loop = true;
        // audioSource.mute = false;

    }

       private void OnEnable()
    {

        interactor.onSelectEntered.AddListener(TakeInput);
        //interactor.onSelectExited.AddListener(StopInput);
        

    }

    private void OnDisable()
    {

        //interactor.onSelectEntered.RemoveListener(TakeInput);
        interactor.onSelectExited.RemoveListener(StopInput);
       

    }

    private void TakeInput(XRBaseInteractor interactable)
    {

        IsGrabbing = true;
        Debug.Log("is grabbing");
        //audioSource.Play();
    }

    private void StopInput(XRBaseInteractor interactable)
    {

        IsGrabbing = false;
        Debug.Log("is releasing");
        //audioSource.Stop();
    }
    
}
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;


public class HandController : MonoBehaviour
{
    public Animator anim;
    public GameObject baby;
    public GameObject Run;
    public GameObject Canvas;
    public GameObject button;

    public void buttonPush()
    {
        anim.SetBool("ButtonPush", true);
    }
    public void start()
    {
        anim.SetBool("return", false);
        button.gameObject.SetActive(false);
        Canvas.SetActive(false);
    }
    public void OnFirstHoverEntered()
    {
        Debug.Log($"{gameObject.name} - OnFirstHoverEntered");
        Canvas.SetActive(true);

    }

    public void OnLastHoverExited()
    {
        Debug.Log($"{gameObject.name} - OnLastHoverExited");
    }

    public void OnHoverEntered()
    {
        Debug.Log($"{gameObject.name} - OnHoverEntered");
       
    }

    public void OnHoverExited()
    {
        Debug.Log($"{gameObject.name} - OnHoverExited");
        Canvas.SetActive(false);

    }

    public void OnFirstSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnFirstSelectEntered");
        baby.GetComponent<AudioSource>().enabled = false;
        Canvas.SetActive(false);
    }

    public void OnLastSelectExited()
    {
        Debug.Log($"{gameObject.name} - OnLastSelectExited");
    }

    public void OnSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnSelectEntered");
        anim.SetBool("getit", true);
        Canvas.SetActive(false);
        Run.GetComponent<Rotate>().enabled = false;
        baby.GetComponent<AudioSource>().enabled = false;
    }

    public void OnSelectExited()
    {
        
        Debug.Log($"{gameObject.name} - OnSelectExited");
        anim.SetBool("dropit", true);
        baby.transform.position = new Vector3(-3, 0, 10);
        baby.transform.rotation = Quaternion.Euler(0, 180, 0);
        button.gameObject.SetActive(true);
        baby.GetComponent<XRGrabInteractable>().enabled = false;

    }

    public void OnActivated()
    {
        Debug.Log($"{gameObject.name} - OnActivated");
    }

    public void OnDeactivated()
    {
        Debug.Log($"{gameObject.name} - OnDeactivated");
    }
}
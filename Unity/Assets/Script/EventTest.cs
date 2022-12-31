using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventTest : MonoBehaviour
{
    public Animator anim;

    public void buttonPush()
    {
        anim.SetBool("ButtonPush", true);
    }

    public void OnFirstHoverEntered()
    {
        Debug.Log($"{gameObject.name} - OnFirstHoverEntered");
        
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
    }

    public void OnFirstSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnFirstSelectEntered");
    }

    public void OnLastSelectExited()
    {
        Debug.Log($"{gameObject.name} - OnLastSelectExited");
    }

    public void OnSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnSelectEntered");
        anim.SetBool("getit", true);
    }

    public void OnSelectExited()
    {
        Debug.Log($"{gameObject.name} - OnSelectExited");
        anim.SetBool("dropit", true);
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
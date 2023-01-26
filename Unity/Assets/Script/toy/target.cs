using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;


public class target : MonoBehaviour
{
    public GameObject toy;
    public void OnFirstHoverEntered()
    {
        Debug.Log($"{gameObject.name} - OnFirstHoverEntered");
        toy.SetActive(true);
    }

    public void OnHoverExited()
    {
        Debug.Log($"{gameObject.name} - OnHoverExited");
        toy.SetActive(false);
    }
    public void OnSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnSelectEntered");
        toy.SetActive(false);
    }

    public void OnSelectExited()
    {        
        Debug.Log($"{gameObject.name} - OnSelectExited");
    }
}
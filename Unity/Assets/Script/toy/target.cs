using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;


public class target : MonoBehaviour
{
    public GameObject toy;
    static bool check = false;
    public void OnFirstHoverEntered()
    {
        if(check == false)
        {
            Debug.Log($"{gameObject.name} - OnFirstHoverEntered");
            toy.SetActive(true);
        }
    }

    public void OnHoverExited()
    {
        if(check == false)
        {
            Debug.Log($"{gameObject.name} - OnHoverExited");
            toy.SetActive(false);
        }
    }
    public void OnSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnSelectEntered");
        toy.SetActive(false);
        check = true;
    }

    public void OnSelectExited()
    {        
        Debug.Log($"{gameObject.name} - OnSelectExited");
        check = false;
    }
}
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;


public class control : MonoBehaviour
{
    public GameObject food;
    static bool check = false;
    public void OnFirstHoverEntered()
    {
        if(check == false)
        {
            Debug.Log($"{gameObject.name} - OnFirstHoverEntered");
            food.SetActive(true);
        }
    }

    public void OnHoverExited()
    {
        if(check == false)
        {
            Debug.Log($"{gameObject.name} - OnHoverExited");
            food.SetActive(false);
        }
    }
    public void OnSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnSelectEntered");
        food.SetActive(false);
        check = true;
    }

    public void OnSelectExited()
    {
        Debug.Log($"{gameObject.name} - OnSelectExited");
        check = false;
    }
}
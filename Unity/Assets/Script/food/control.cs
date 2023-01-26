using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;


public class control : MonoBehaviour
{
    public GameObject food;
    public void OnFirstHoverEntered()
    {
        Debug.Log($"{gameObject.name} - OnFirstHoverEntered");
        food.SetActive(true);
    }

    public void OnHoverExited()
    {
        Debug.Log($"{gameObject.name} - OnHoverExited");
        food.SetActive(false);
    }
    public void OnSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnSelectEntered");
        food.SetActive(false);
    }

    public void OnSelectExited()
    {
        Debug.Log($"{gameObject.name} - OnSelectExited");
    }
}
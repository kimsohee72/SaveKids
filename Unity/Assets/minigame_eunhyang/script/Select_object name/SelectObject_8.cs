using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectObject_8 : MonoBehaviour
{   
    TMP_Text object_name;
    public GameObject o;
    static bool b = false;

    public void first()
    {
        if (b == false)
        {
            o.SetActive(true);
        }


    }
    public void exited()
    {
        o.SetActive(false);
    }
    public void OnSelectEntered()
    {   
       
        object_name = GameObject.Find("text_8").GetComponent<TextMeshPro>();
        
        object_name.text = $"{gameObject.name}";
        o.SetActive(false);
        b = true;
    }

    public void OnSelectExited()
    {
        object_name.text = " ";
        b = false;

    }

}

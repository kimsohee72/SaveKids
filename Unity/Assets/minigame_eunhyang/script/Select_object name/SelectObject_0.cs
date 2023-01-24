using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectObject_0 : MonoBehaviour
{   
    TMP_Text object_name;
    
    public void OnSelectEntered()
    {   
       
        object_name = GameObject.Find("text_0").GetComponent<TextMeshPro>();
        
        object_name.text = $"{gameObject.name}";
        
    }

    public void OnSelectExited()
    {
        object_name.text = " ";
    
    }
    
}

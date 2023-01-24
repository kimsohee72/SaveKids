using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class setting : MonoBehaviour
{
    Vector3 init = new Vector3((float)-2.7, (float)0.45, (float)7.6);
    Vector3 destination = new Vector3((float)-2.8, 1, 9);
    public GameObject baby1;
    public GameObject baby2;
    public GameObject button;
    public GameObject b;
    public GameObject spoon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 speed = Vector3.zero;
        baby1.GetComponent<XRGrabInteractable>().enabled = true;
        baby2.GetComponent<XRGrabInteractable>().enabled = true;
        button.gameObject.SetActive(false);
        spoon.transform.position = Vector3.SmoothDamp(init, destination, ref speed, 0.1f);
        b.GetComponent<AudioSource>().enabled = false;
        spoon.GetComponent<spoonmove>().enabled = false;
    }
}

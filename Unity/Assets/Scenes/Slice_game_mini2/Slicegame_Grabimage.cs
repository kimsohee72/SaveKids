using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicegame_Grabimage : MonoBehaviour
{
    public GameObject Grab_image;

    void Start()
	{
        Grab_image.SetActive(true);
	}

    void OnTriggerEnter(Collider col)
    {
        Grab_image.SetActive(false);
    }
}

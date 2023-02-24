using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropSoundControl : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        audioSource.mute = false;
        audioSource.Stop();
    }

    public void enter(Collision collision)
    {
        if (collision.gameObject.name == "BPS_Table")
        {
            audioSource.Stop();
            audioSource.Play();
        }
    }

}

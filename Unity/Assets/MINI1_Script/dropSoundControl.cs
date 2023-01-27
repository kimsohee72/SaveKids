using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropSoundControl : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        audioSource.mute = false;
        audioSource.Stop();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        
        if (collision.gameObject.name == "Spoon" || collision.gameObject.name == "BabyRattle_01")
        {
            Debug.Log("trigger");
            audioSource.Play();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class homeButton : MonoBehaviour
{
    public Button btnHome;

    AudioSource homeAudio;
    // Start is called before the first frame update
    void Start()
    {
        homeAudio = GetComponent<AudioSource>();

        btnHome = GetComponent<Button>();
        btnHome.onClick.AddListener(pressHomeButton);
    }
    void pressHomeButton()
    {
        Debug.Log("adfA");
        //
        homeAudio.Play();
        SceneManager.LoadScene("main1");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gohome : MonoBehaviour
{
    public GameObject Kniknife;
    void Start()
    {
        Kniknife.SetActive(false);
    }

    public void Slicegame_main()
    {
        SceneManager.LoadScene("main1");
    }
}

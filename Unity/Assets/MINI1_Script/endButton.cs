using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endButton : MonoBehaviour
{
    public Button btnEnd;
    GameObject rattle;
    GameObject spoon;
    GameObject bowl;
    public GameObject panelEnd;
    public GameObject panelGuide;

    // Start is called before the first frame update
    void Start()
    {
        btnEnd = GetComponent<Button>();
        btnEnd.onClick.AddListener(pressButton);

        rattle = GameObject.Find("BabyRattle_01");
        spoon = GameObject.Find("Spoon");
        bowl = GameObject.Find("Bowl_02");
        panelEnd = GameObject.Find("PanelEnd");


        rattle.SetActive(false);
        spoon.SetActive(false);
        bowl.SetActive(false);
        panelGuide.SetActive(false);
    }

    void pressButton()
    {
        SceneManager.LoadScene("main1");
    }
}

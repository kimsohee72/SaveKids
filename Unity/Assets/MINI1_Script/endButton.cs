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
    GameObject baby;
    GameObject babySit;
    GameObject babyTable;
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
        baby = GameObject.Find("ToonBabyA");
        babySit = GameObject.Find("HighChair_01");
        babyTable = GameObject.Find("Bib_01");
        panelEnd = GameObject.Find("PanelEnd");


        rattle.SetActive(false);
        spoon.SetActive(false);
        bowl.SetActive(false);
        baby.SetActive(false);
        babySit.SetActive(false);
        babyTable.SetActive(false);
        panelGuide.SetActive(false);
    }

    void pressButton()
    {
        SceneManager.LoadScene("main1");
    }
}

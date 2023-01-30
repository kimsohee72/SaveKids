using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startButtonClick : MonoBehaviour
{
    public Button btnStart;
    GameObject baby;
    GameObject rattle;
    GameObject spoon;
    GameObject bowl;
    GameObject panelStart;
    GameObject panelEnd;

    GameObject panelGuide;
    GameObject panelGuide1;
    GameObject panelGuide2;
    GameObject panelGuide3;

    GameObject babyChair;
    GameObject bib;

    // Start is called before the first frame update
    void Awake()
    {
        btnStart = GetComponent<Button>();
        btnStart.onClick.AddListener(pressButton);

        baby = GameObject.Find("ToonBabyA");
        rattle = GameObject.Find("BabyRattle_01");
        spoon = GameObject.Find("Spoon");
        bowl = GameObject.Find("Bowl_02");
        panelStart = GameObject.Find("PanelStart");
        panelEnd = GameObject.Find("PanelEnd");
        panelGuide = GameObject.Find("PanelGuide");
        panelGuide1 = GameObject.Find("PanelGuide1");
        panelGuide2 = GameObject.Find("PanelGuide2");
        panelGuide3 = GameObject.Find("PanelGuide3");
        babyChair = GameObject.Find("HighChair_01");
        bib = GameObject.Find("Bib_01");

        baby.SetActive(false);
        rattle.SetActive(false);
        spoon.SetActive(false);
        bowl.SetActive(false);
        panelStart.SetActive(true);
        panelEnd.SetActive(false);
        panelGuide.SetActive(false);
        panelGuide1.SetActive(false);
        panelGuide2.SetActive(false);
        panelGuide3.SetActive(false);
        babyChair.SetActive(false);
        bib.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void pressButton()
    {
        baby.SetActive(true);
        rattle.SetActive(true);
        spoon.SetActive(true);
        bowl.SetActive(true);
        panelStart.SetActive(false);
        panelGuide.SetActive(true);
        panelGuide1.SetActive(true);
        babyChair.SetActive(true);
        bib.SetActive(true);

    }
}



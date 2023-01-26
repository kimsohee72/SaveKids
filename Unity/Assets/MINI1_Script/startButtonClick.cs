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
    GameObject panel;

    // Start is called before the first frame update
    void Awake()
    {
        btnStart = GetComponent<Button>();
        btnStart.onClick.AddListener(pressButton);

        baby = GameObject.Find("ToonBabyA");
        rattle = GameObject.Find("BabyRattle_01");
        spoon = GameObject.Find("Spoon");
        bowl = GameObject.Find("Bowl_02");
        panel = GameObject.Find("PanelStart");

        baby.SetActive(false);
        rattle.SetActive(false);
        spoon.SetActive(false);
        bowl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void pressButton()
    {
        Debug.Log("press");

        baby.SetActive(true);
        rattle.SetActive(true);
        spoon.SetActive(true);
        bowl.SetActive(true);
        panel.SetActive(false);

    }
}



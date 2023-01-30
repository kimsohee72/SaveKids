using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool apple, beef, banana, blueberry, bread, carrot, cheese, cherry, rice, watermelon;
    public bool coin, battery, chess, bell, ring, block;
    public bool ball, book, chessgame, crayon, magnet, marble, stacker, teddybear, train;
    GameObject Finish;
    public GameObject food, table, chair, spoon, plate, bib, check, info, list, ending;
    public GameObject toy, info_6, list_6, box, ending_6;
    public GameObject toy_7, list_7, ending_7, baby;

    void FixedUpdate()
    {
        Finish = GameObject.FindGameObjectWithTag("Finish");

        if (apple == true && beef == true && blueberry == true && banana == true && bread == true && carrot == true && cheese == true && rice == true && watermelon == true)
        {
            Debug.Log("3번 끝");
            food.SetActive(false);
            table.SetActive(false);
            chair.SetActive(false);
            spoon.SetActive(false);
            plate.SetActive(false);
            bib.SetActive(false);
            check.SetActive(false);
            info.SetActive(false);
            list.SetActive(false);
            ending.SetActive(true);
        }

        if (coin == true && battery == true && chess == true && bell == true && ring == true && block == true)
        {
            Debug.Log("6번 끝");
            toy.SetActive(false);
            info_6.SetActive(false);
            list_6.SetActive(false);
            box.SetActive(false);
            ending_6.SetActive(true);
        }

        if (ball == true && book == true && chessgame == true && crayon == true && magnet == true && marble == true && stacker == true && teddybear == true && train == true)
        {
            Debug.Log("7번 끝");
            toy_7.SetActive(false);
            list_7.SetActive(false);
            baby.SetActive(false);
            ending_7.SetActive(true);
        }
    }
}

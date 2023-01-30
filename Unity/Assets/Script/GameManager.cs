using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool apple, beef, banana, blueberry, bread, carrot, cheese, cherry, rice, watermelon;
    public bool coin, battery, chess, bell, ring, block;
    GameObject Finish;
    public GameObject food, table, chair, spoon, plate, bib, check, info, list, ending;
    public GameObject toy, info_6, list_6, box, ending_6;

    void FixedUpdate()
    {
        Finish = GameObject.FindGameObjectWithTag("Finish");

        if (apple == true && beef == true && blueberry == true && banana == true && bread == true && carrot == true && cheese == true && rice == true && watermelon == true)
        {
            Debug.Log("3�� ��");
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
            Debug.Log("6�� ��");
            toy.SetActive(false);
            info_6.SetActive(false);
            list_6.SetActive(false);
            box.SetActive(false);
            ending_6.SetActive(true);
        }
    }
}

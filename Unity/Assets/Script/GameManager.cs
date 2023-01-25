using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool apple, beef, banana, blueberry, bread, carrot, cheese, cherry, rice, watermelon;
    public bool coin, battery, chess, bell, ring, block;
    GameObject Finish;

    void FixedUpdate()
    {
        Finish = GameObject.FindGameObjectWithTag("Finish");

        if (apple == true && beef == true && blueberry == true && banana == true && bread == true && carrot == true && cheese == true && rice == true && watermelon == true)
        {
            Debug.Log("3번 끝");
        }

        if (coin == true && battery == true && chess == true && bell == true && ring == true && block == true)
        {
            Debug.Log("6번 끝");
        }
    }
}

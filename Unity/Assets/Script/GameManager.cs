using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int point;
    public bool coin, battery, chess, bell, ring, block;
    GameObject Finish;

    void FixedUpdate()
    {
        Finish = GameObject.FindGameObjectWithTag("Finish");
        if(point >= 6)
        {
            //Finish.SetActive(true);
            Debug.Log("³¡");
        }

        if(coin == true && battery == true && chess == true && bell == true && ring == true && block == true)
        {
            Debug.Log("6¹ø ³¡");
        }
    }
}

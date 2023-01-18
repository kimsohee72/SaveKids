using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoonmove : MonoBehaviour
{
    public GameObject spoon;
    Vector3 init = new Vector3((float)-2.7,(float)0.45,(float)7.6);
    Vector3 destination = new Vector3((float)-2.9, 1, 9);

    void FixedUpdate()
    {
        /*
        transform.position =
            Vector3.MoveTowards(start , destination, 1);
        */

        Vector3 speed = Vector3.zero; // (0,0,0) 은 .zero 로도 표현가능
        spoon.transform.position = Vector3.SmoothDamp(destination,init, ref speed, 0.5f);
        
    }

}

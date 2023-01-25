using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkSceneCorrect : MonoBehaviour
{
    public int countEat = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countEat == 2)
        {
            Debug.Log("2 times");
        }
    }
}

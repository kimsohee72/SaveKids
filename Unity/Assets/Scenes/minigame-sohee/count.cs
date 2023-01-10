using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour
{
    public GameObject baby1;
    public GameObject baby2;
    public int a;
    int b;
    // Start is called before the first frame update
    void Start()
    {
        b = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (baby1.activeSelf == true || baby2.activeSelf == true)
        {
            b++;
            Debug.Log("Hello");
        }
    }
}

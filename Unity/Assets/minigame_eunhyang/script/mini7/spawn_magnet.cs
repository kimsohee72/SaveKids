using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_magnet : MonoBehaviour
{
    public GameObject o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        o.transform.position = new Vector3(-5.078311f, 0.09850025f, 1.223893f);
    }
}

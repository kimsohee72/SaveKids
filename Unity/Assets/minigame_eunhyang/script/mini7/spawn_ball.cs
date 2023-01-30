using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_ball : MonoBehaviour
{
    public GameObject o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        o.transform.position = new Vector3(-1.917093f, 0.2073188f, 1.083403f);
    }
}

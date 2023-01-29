using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_doll : MonoBehaviour
{
    public GameObject o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        o.transform.position = new Vector3(-3.023f, 0.035f, 10.155f);
        o.transform.rotation = Quaternion.Euler(0, 162.362f, 0);
    }
}

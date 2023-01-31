using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_dotball : MonoBehaviour
{
    public GameObject o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        o.transform.position = new Vector3(-2.85708f, 0.03550026f, 0.9814863f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public Transform player;
    public GameObject o;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        o.transform.LookAt(player);
        o.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}

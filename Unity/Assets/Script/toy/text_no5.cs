using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_no5 : MonoBehaviour
{
    public Transform player;
    public RectTransform o;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        
        o.LookAt(player);
        o.rotation = Quaternion.Euler(0, 0, 0);
        
    }
}

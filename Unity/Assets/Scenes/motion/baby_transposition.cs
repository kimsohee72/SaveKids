using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baby_transposition : MonoBehaviour
{
    public GameObject LHand;
    public GameObject RHand;
    public GameObject Baby;

    int num = 0;

    Vector3 Lpos;
    Vector3 Rpos;

    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = Baby.GetComponent<Transform>();
        Baby.transform.position = new Vector3(-3.528f, 0f, -10.812f);
        target.rotation = Quaternion.Euler(-90, 0, -90);
    }

    // Update is called once per frame
    void Update()
    {
        num++;

        if(num > 800)
		{
            transposition_R();
		}
        
        if(num > 2000)
		{
            transposition_L();
		}

        if (num > 4700)
        {
            transposition_R();
        }

        if(num > 8000)
		{
            Baby.transform.position = new Vector3(-3.528f, 0f, -10.812f);
        }

    }

    void transposition_R()
	{
        target = Baby.GetComponent<Transform>();
        Rpos = RHand.transform.position;
        Baby.transform.position = Rpos;
        target.rotation = Quaternion.Euler(-106.781f, -87.883f, 19.298f);
    }

    void transposition_L()
    {
        target = Baby.GetComponent<Transform>();
        Lpos = LHand.transform.position;
        Baby.transform.position = Lpos;
        target.rotation = Quaternion.Euler(-240.509f, 69.285f, -8.110992f);
    }
}

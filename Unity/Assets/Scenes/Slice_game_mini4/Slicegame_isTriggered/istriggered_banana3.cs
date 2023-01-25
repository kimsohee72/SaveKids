using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana3 : MonoBehaviour
{
    public GameObject Bananaguideline3;
    public GameObject ThisBanana3;
    public GameObject nextBanana3;
    public bool banana3;

    // Start is called before the first frame update
    void Start()
    {
        ThisBanana3.tag = "NotSlice";
        nextBanana3.tag = "NotSlice";
        ThisBanana3.layer = 5;
        nextBanana3.layer = 5;
        Bananaguideline3.SetActive(false);
        banana3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisBanana3.tag == "Slice" && nextBanana3.tag == "NotSlice")
        {
            Bananaguideline3.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana3 = true;
            Bananaguideline3.SetActive(false);
            nextBanana3.tag = "Slice";
            nextBanana3.layer = 6;
        }
	}
}

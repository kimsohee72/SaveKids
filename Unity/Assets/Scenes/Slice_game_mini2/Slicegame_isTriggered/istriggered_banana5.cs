using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana5 : MonoBehaviour
{
    public GameObject Bananaguideline2;
    public GameObject ThisBanana2;
    public GameObject nextBanana2;
    public bool banana5;

    // Start is called before the first frame update
    void Start()
    {
        ThisBanana2.tag = "NotSlice";
        nextBanana2.tag = "NotSlice";
        ThisBanana2.layer = 5;
        nextBanana2.layer = 5;
        Bananaguideline2.SetActive(false);
        banana5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisBanana2.tag == "Slice" && nextBanana2.tag == "NotSlice")
        {
            Bananaguideline2.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana5 = true;
            Bananaguideline2.SetActive(false);
            nextBanana2.tag = "Slice";
            nextBanana2.layer = 6;
        }
	}
}

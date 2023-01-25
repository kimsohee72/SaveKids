using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_banana8 : MonoBehaviour
{
    public GameObject Bananaguideline1;
    public GameObject ThisBanana1;
    public GameObject nextBanana1;
    public bool banana8;

    // Start is called before the first frame update
    void Start()
    {
        ThisBanana1.tag = "Slice";
        nextBanana1.tag = "NotSlice";
        ThisBanana1.layer = 6;
        nextBanana1.layer = 5;
        Bananaguideline1.SetActive(false);
        banana8 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ThisBanana1.tag == "Slice" && nextBanana1.tag == "NotSlice")
		{
            Bananaguideline1.SetActive(true);
		}
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            banana8 = true;
            Bananaguideline1.SetActive(false);
            nextBanana1.tag = "Slice";
            nextBanana1.layer = 6;
		}
	}
}

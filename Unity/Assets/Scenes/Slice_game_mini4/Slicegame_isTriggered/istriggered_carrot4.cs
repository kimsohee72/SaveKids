using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot4 : MonoBehaviour
{
    public GameObject guideline4;
    public GameObject ThisCarrot4;
    public GameObject nextCarrot4;
    public bool carrot4;

    // Start is called before the first frame update
    void Start()
    {
        ThisCarrot4.tag = "NotSlice";
        nextCarrot4.tag = "NotSlice";
        ThisCarrot4.layer = 5;
        nextCarrot4.layer = 5;
        guideline4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisCarrot4.tag == "Slice" && nextCarrot4.tag == "NotSlice")
        {
            guideline4.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            carrot4 = true;
            guideline4.SetActive(false);
            nextCarrot4.tag = "Slice";
            nextCarrot4.layer = 6;
        }
	}
}

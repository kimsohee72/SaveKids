using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot2 : MonoBehaviour
{
    public GameObject guideline2;
    public GameObject ThisCarrot2;
    public GameObject nextCarrot2;
    public bool carrot2;

    // Start is called before the first frame update
    void Start()
    {
        ThisCarrot2.tag = "NotSlice";
        nextCarrot2.tag = "NotSlice";
        ThisCarrot2.layer = 5;
        nextCarrot2.layer = 5;
        guideline2.SetActive(false);
        carrot2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisCarrot2.tag == "Slice" && nextCarrot2.tag == "NotSlice")
        {
            guideline2.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            carrot2 = true;
            guideline2.SetActive(false);
            nextCarrot2.tag = "Slice";
            nextCarrot2.layer = 6;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot5 : MonoBehaviour
{
    public GameObject guideline5;
    public GameObject ThisCarrot5;
    public GameObject nextCarrot5;
    public bool carrot5;

    // Start is called before the first frame update
    void Start()
    {
        ThisCarrot5.tag = "NotSlice";
        nextCarrot5.tag = "NotSlice";
        ThisCarrot5.layer = 5;
        nextCarrot5.layer = 5;
        guideline5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisCarrot5.tag == "Slice" && nextCarrot5.tag == "NotSlice")
        {
            guideline5.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            carrot5 = true;
            guideline5.SetActive(false);
            nextCarrot5.tag = "Slice";
            nextCarrot5.layer = 6;
        }
	}
}

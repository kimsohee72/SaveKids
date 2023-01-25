using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot3: MonoBehaviour
{
    public GameObject guideline3;
    public GameObject ThisCarrot3;
    public GameObject nextCarrot3;
    public bool carrot3;

    // Start is called before the first frame update
    void Start()
    {
        ThisCarrot3.tag = "NotSlice";
        nextCarrot3.tag = "NotSlice";
        ThisCarrot3.layer = 5;
        nextCarrot3.layer = 5;
        guideline3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisCarrot3.tag == "Slice" && nextCarrot3.tag == "NotSlice")
        {
            guideline3.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            carrot3 = true;
            guideline3.SetActive(false);
            nextCarrot3.tag = "Slice";
            nextCarrot3.layer = 6;
        }
	}
}

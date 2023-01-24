using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot1 : MonoBehaviour
{
    public GameObject guideline1;
    public GameObject ThisCarrot1;
    public GameObject nextCarrot1;
    public bool carrot1;

    // Start is called before the first frame update
    void Start()
    {
        ThisCarrot1.tag = "Slice";
        nextCarrot1.tag = "NotSlice";
        guideline1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisCarrot1.tag == "Slice" && nextCarrot1.tag == "NotSlice")
        {
            guideline1.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            carrot1 = true;
            guideline1.SetActive(false);
            nextCarrot1.tag = "Slice";
            nextCarrot1.layer = 6;
		}
	}
}

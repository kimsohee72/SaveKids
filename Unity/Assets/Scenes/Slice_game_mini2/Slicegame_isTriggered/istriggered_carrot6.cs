using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot6 : MonoBehaviour
{
    public GameObject guideline6;
    public GameObject ThisCarrot6;
    public GameObject nextCarrot6;
    public bool carrot6;

    // Start is called before the first frame update
    void Start()
    {
        ThisCarrot6.tag = "NotSlice";
        nextCarrot6.tag = "NotSlice";
        ThisCarrot6.layer = 5;
        nextCarrot6.layer = 5;
        guideline6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisCarrot6.tag == "Slice" && nextCarrot6.tag == "NotSlice")
        {
            guideline6.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            carrot6 = true;
            guideline6.SetActive(false);
            nextCarrot6.tag = "Slice";
            nextCarrot6.layer = 6;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot3: MonoBehaviour
{
    public GameObject guideline;
    public GameObject ThisCarrot;
    public GameObject nextCarrot;
    public bool carrot3;

    // Start is called before the first frame update
    void Start()
    {
        ThisCarrot.tag = "Untagged";
        nextCarrot.tag = "Untagged";
        guideline.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisCarrot.tag == "Slice" && nextCarrot.tag == "Untagged") ;
        {
            guideline.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife")
		{
            carrot3 = true;
            guideline.SetActive(false);
            nextCarrot.tag = "Slice";
        }
	}
}

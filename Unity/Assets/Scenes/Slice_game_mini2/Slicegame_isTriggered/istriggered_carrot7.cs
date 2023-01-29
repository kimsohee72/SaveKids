using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot7 : MonoBehaviour
{
    public GameObject guideline7;
    public GameObject ThisCarrot7;
    public GameObject nextCarrot7;
    public bool carrot7;
    public GameObject SliceSFX;
    AudioSource sliceSFX;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        sliceSFX = SliceSFX.GetComponent<AudioSource>();
        ThisCarrot7.tag = "NotSlice";
        nextCarrot7.tag = "NotSlice";
        ThisCarrot7.layer = 5;
        nextCarrot7.layer = 5;
        guideline7.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisCarrot7.tag == "Slice" && nextCarrot7.tag == "NotSlice")
        {
            guideline7.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col)
	{
        if(col.gameObject.tag == "Knife" && this.gameObject.tag == "Slice")
		{
            if (count == 0)
            {
                sliceSFX.Play();
                count += 1;
            }
            carrot7 = true;
            guideline7.SetActive(false);
            nextCarrot7.tag = "Slice";
            nextCarrot7.layer = 6;
        }
	}
}

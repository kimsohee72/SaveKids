using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istriggered_carrot8 : MonoBehaviour
{
    public bool carrot8;
    public GameObject SliceSFX;
    AudioSource sliceSFX;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        sliceSFX = SliceSFX.GetComponent<AudioSource>();
        carrot8 = false;
    }

    // Update is called once per frame
    void Update()
    {

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
            carrot8 = true;
        }
	}
}

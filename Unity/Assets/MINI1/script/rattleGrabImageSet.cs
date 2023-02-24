using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rattleGrabImageSet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rattleImage;

    bool rattleGrabbed = false;
        
    public void inrayobject()
    {
        if(rattleGrabbed == false)
            rattleImage.SetActive(true);
    }

    public void outrayobject()
    {
        rattleImage.SetActive(false);
    }

    public void select()
    {
        rattleGrabbed = true;
        rattleImage.SetActive(false);
    }

    public void unselect()
    {
        rattleGrabbed = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoonGrabImageSet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spoonImage;

    bool spoonGrabbed = false;
        
    public void inrayobject()
    {
        if(spoonGrabbed == false)
            spoonImage.SetActive(true);
    }

    public void outrayobject()
    {
        spoonImage.SetActive(false);
    }

    public void select()
    {
        spoonGrabbed = true;
        spoonImage.SetActive(false);
    }

    public void unselect()
    {
        spoonGrabbed = false;
    }

}

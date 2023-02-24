using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rattleCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {  
        GameObject.Find("rattleDropSound").GetComponent<dropSoundControl>().enter(collision);
    }
}

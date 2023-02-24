using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoonCollision : MonoBehaviour
{ 
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("spoonDropSound").GetComponent<dropSoundControl>().enter(collision);
    }
}

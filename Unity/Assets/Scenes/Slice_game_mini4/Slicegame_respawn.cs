using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicegame_respawn : MonoBehaviour
{
    public GameObject Slicegame_Knife;
    Transform target;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Knife")
		{
            target = Slicegame_Knife.GetComponent<Transform>();
            target.position = new Vector3(-3.6f, 1.3f, 0.7f);
            target.rotation = Quaternion.Euler(0, 90, 0);
		}
    }
}

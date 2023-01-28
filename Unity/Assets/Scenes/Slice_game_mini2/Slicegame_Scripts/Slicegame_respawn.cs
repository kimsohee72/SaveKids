using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Slicegame_respawn : MonoBehaviour
{
    public GameObject Slicegame_grab;
    Transform target;
    int count;

    void Start()
    {
        count = 0;
        Slicegame_grab.SetActive(false);
    }

    public void OnFirstHoverEntered()
    {
        if(count == 0)
		{
            Slicegame_grab.SetActive(true);
		}
    }

    public void OnLastHoverExited()
    {

    }

    public void OnHoverEntered()
    {

    }

    public void OnHoverExited()
    {
        Slicegame_grab.SetActive(false);
    }

    public void OnFirstSelectEntered()
    {

    }

    public void OnLastSelectExited()
    {

    }

    public void OnSelectEntered()
    {
        count += 1;
        Slicegame_grab.SetActive(false);
    }

    public void OnSelectExited(GameObject Slicegame_Knife)
    {
        count = 0;
        target = Slicegame_Knife.GetComponent<Transform>();
        target.position = new Vector3(-3.6f, 1.3f, 0.7f);
        target.rotation = Quaternion.Euler(270, 90, 0);
    }

    public void OnActivated()
    {

    }

    public void OnDeactivated()
    {

    }

}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Slicegame_respawn : MonoBehaviour
{
    public GameObject Slicegame_grab;
    Transform target;

    void Start()
    {
        Slicegame_grab.SetActive(false);
    }

    public void OnFirstHoverEntered()
    {
        Slicegame_grab.SetActive(true);
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
        Slicegame_grab.SetActive(false);
    }

    public void OnSelectExited(GameObject Slicegame_Knife)
    {
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

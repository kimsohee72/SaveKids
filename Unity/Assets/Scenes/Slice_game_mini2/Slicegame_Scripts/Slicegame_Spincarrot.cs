using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicegame_Spincarrot : MonoBehaviour
{
    float rotSpeed = 100f;

    void Update()
    {
        transform.Rotate(new Vector3(rotSpeed * Time.deltaTime, 0, 0));
    }
}

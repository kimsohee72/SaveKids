using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    Transform Transform_;
    Vector3 firstLocation = new Vector3(0, 0, 0);
    Quaternion firstRotation = new Quaternion();
    void Start()
    {
        Transform_ = GetComponent<Transform>();
        firstLocation = Transform_.position;
        firstRotation = Transform_.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Transform_.position.y < 0.8f
            || Transform_.position.x < -4.1f
            || Transform_.position.x > -1.5f
            || Transform_.position.z > 7.0f
            || Transform_.position.z < 4.5f)
        {
            Debug.Log("NO");
            Transform_.position = firstLocation;
            Transform_.rotation = firstRotation;
        }
    }
}

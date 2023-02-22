using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainSpawn : MonoBehaviour
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
        if (Transform_.position.y < -0.8f)
        {
            Debug.Log("NO");
            Transform_.position = firstLocation;
            Transform_.rotation = firstRotation;
        }
    }
}

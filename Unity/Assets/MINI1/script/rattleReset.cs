using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rattleReset : MonoBehaviour
{
    // Start is called before the first frame update
    Transform rattleTransform;
    Vector3 firstLocation = new Vector3(0, 0, 0);
    Quaternion firstRotation = new Quaternion();

    void Start()
    {
        rattleTransform = GetComponent<Transform>();
        firstLocation = rattleTransform.position;
        firstRotation = rattleTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (rattleTransform.position.y < 0.8f
            || rattleTransform.position.x < -4.1f
            || rattleTransform.position.x > -1.5f
            || rattleTransform.position.z > 7.0f
            || rattleTransform.position.z < 4.5f)
        {
            Debug.Log("NO");
            rattleTransform.position = firstLocation;
            rattleTransform.rotation = firstRotation;
        }
    }
}

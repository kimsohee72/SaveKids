using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoonReset : MonoBehaviour
{
    // Start is called before the first frame update
    Transform spoonTransform;
    Vector3 firstLocation = new Vector3(0, 0, 0);
    Quaternion firstRotation = new Quaternion();
    void Start()
    {
        spoonTransform = GetComponent<Transform>();
        firstLocation = spoonTransform.position;
        firstRotation = spoonTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (spoonTransform.position.y < 0.8f
            || spoonTransform.position.x < -4.1f
            || spoonTransform.position.x > -1.5f
            || spoonTransform.position.z > 7.0f
            || spoonTransform.position.z < 4.5f)
        {
            Debug.Log("NO");
            spoonTransform.position = firstLocation;
            spoonTransform.rotation = firstRotation;
        }
    }
}

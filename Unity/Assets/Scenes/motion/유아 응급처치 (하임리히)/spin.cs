using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public GameObject nurse;
    float rot;
    // Start is called before the first frame update
    void Start()
    {
        rot = nurse.transform.rotation.y + 90;
        Debug.Log(rot);
    }

    // Update is called once per frame
    void Update()
    {
        nurse.transform.rotation = Quaternion.Euler(0, rot , 0);
    }

    public void spin_right()
    {
        rot -= 5;
    }
    public void spin_left()
    {
        rot += 5;
    }
}

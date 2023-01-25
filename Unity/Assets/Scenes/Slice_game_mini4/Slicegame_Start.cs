using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicegame_progress : MonoBehaviour
{
    public GameObject Start_part;
    public GameObject Game_part;
    public GameObject Finish_part;
    // Start is called before the first frame update
    void Start()
    {
        Start_part.SetActive(true);
        Game_part.SetActive(false);
        Finish_part.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class change : MonoBehaviour
{
    public Animator anim;
    public GameObject lie;
    public GameObject click;
    public GameObject hint;
    float y;
    static int a=0;
    
    // Start is called before the first frame update
    void Start()
    {
        y = click.GetComponent<RectTransform>().anchoredPosition.y;
        y = y - 0.3f;

    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("lie_idle1"))
        {
            hint.SetActive(true);
            lie.GetComponent<XRGrabInteractable>().enabled = true;
            lie.transform.rotation = Quaternion.Euler(0, 0, 0);
            click.transform.rotation = Quaternion.Euler(0, 0, 0);
            click.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, y);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("lie_cry")&&a==0)
        {
            lie.GetComponent<AudioSource>().enabled = true;
            a++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public Animator anim;
    public GameObject next_button;
    int a;
    void Start(){
        a = 1;
    }
    void Update(){
        if (a > 3){
            next_button.gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    public void buttonPush_next()
    {
        anim.SetBool(a.ToString(), true);
        a++;
    }
    public void buttonPush_again(){
        anim.Play("Take 2022-11-24 01_18_14 PM",-1,0f);
    }
}

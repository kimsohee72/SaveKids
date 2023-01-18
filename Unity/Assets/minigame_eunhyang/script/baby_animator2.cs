using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baby_animator2 : MonoBehaviour
{
  Animator animator; 

    void Start(){
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    /*void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            animator.SetBool("Looking", true);
        }
         if(Input.GetKeyDown(KeyCode.O)){
            animator.SetBool("Looking", false);
            animator.SetBool("Disgorge", true);
        }
        
    }*/
    
    void OnTriggerEnter(Collider other){ // select 됐을 때
        
        /*if(other.tag == "Toy"){
            animator.SetBool("Looking", true);}*/

       if(animator.GetBool("Looking") == true){
            if(other.tag == "Player"){
            animator.SetBool("Disgorge", true);
            }
        }
        
    }

    /*void OnTriggerExit(Collider other){ // select 됐을 때
        if(other.tag == "Toy"){
        animator.SetBool("Looking", false);}
    }*/

}

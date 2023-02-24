using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baby_animator : MonoBehaviour
{
  Animator animator; 
  public GameObject 접시;
  public GameObject 인형;
  public GameObject 인형클릭;
  public GameObject 접시클릭;
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
        
        if(other.tag == "Toy"){
            animator.SetBool("Looking", true);
            animator.SetInteger("check", 1);
            접시.SetActive(true);
            인형.SetActive(false);
            접시클릭.SetActive(true);
            인형클릭.SetActive(false);
            }

       /*if(animator.GetBool("Looking") == true){
            if(other.tag == "Player"){
            animator.SetBool("Disgorge", true);
            }
        }*/
        
    }

    void OnTriggerExit(Collider other){ // select 됐을 때
        if(other.tag == "Toy"){
            접시.SetActive(false);
            인형.SetActive(true);
        animator.SetBool("Looking", false);
        animator.SetInteger("check", 0);}
    }

}

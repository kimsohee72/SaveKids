using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baby_animator2 : MonoBehaviour
{
  Animator animator; 
  public GameObject 접시안내;
  public GameObject 접시클릭;
 public  AudioSource audioSource;


    void Start(){
        this.animator = GetComponent<Animator>();
        audioSource.GetComponent<AudioSource>();
        audioSource.playOnAwake=false;
        audioSource.loop = false;
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
            //audioSource.playOnAwake=true;
            audioSource.Play();
            접시안내.SetActive(false);
            접시클릭.SetActive(false);

            }
        }
        
    }

    /*void OnTriggerExit(Collider other){ // select 됐을 때
        if(other.tag == "Toy"){
        animator.SetBool("Looking", false);}
    }*/

}

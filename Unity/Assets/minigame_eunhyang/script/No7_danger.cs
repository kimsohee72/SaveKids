using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class No7_danger : MonoBehaviour
{
    TMP_Text info;
    Color alpha;
    public float alphaSpeed;
    Color color;

    void Start(){
        info = GameObject.Find("text_danger").GetComponent<TextMeshPro>();
        alpha = info.color;
        color = info.color;
    }

    void Update(){
        alpha = info.color;
        alpha.a = Mathf.Lerp(alpha.a, 0, Time.deltaTime * alphaSpeed);
        info.color = alpha;
        
    }
    
    void OnTriggerEnter(Collider other){ // select 됐을 때
        
        /*if(other.tag == "Toy"){
            animator.SetBool("Looking", true);}*/

       if(other.tag == "danger"){
        info.color = color;
            info.text = "좋아요!";;
       }
       if(other.tag == "safe"){
        info.color = color;
            info.text = "다시 생각해 보세요!";
       }
            
        
    }


}


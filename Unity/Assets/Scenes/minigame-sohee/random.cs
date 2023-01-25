using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class random : MonoBehaviour
{
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public GameObject baby1;
    public GameObject baby2;
    public GameObject baby3;
    public GameObject button;
    public GameObject table;
    public GameObject end;
    public int a;
    static int b;
    static int n=-1;
    
    // Start is called before the first frame update
    void Start()
    {

        if (baby3.activeSelf == true)
        {
            Debug.Log("hello");
            Invoke("LaunchProjectile", 3);
            b= 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((anim1.GetCurrentAnimatorStateInfo(0).IsName("end") || anim2.GetCurrentAnimatorStateInfo(0).IsName("end")))
        {

            if (b > a)
            {
                baby2.SetActive(false);
                baby1.SetActive(false);
                baby3.SetActive(false);
                button.SetActive(false);
                table.SetActive(false);
                end.SetActive(true);
                
            }
            else
            {
                baby2.SetActive(false);
                baby1.SetActive(false);
                baby3.SetActive(true);
                Invoke("LaunchProjectile", 3);
            }
        }
        
    }

    void LaunchProjectile()
    {
        Debug.Log($"b : {b}");
        b = b + 1;
        baby3.SetActive(false);
        if (n == -1)
        {
            n = Random.Range(0, 2);
        }
        else
        {
            if (n == 0)
            {
                n = 1;
            }
            else
            {
                n = 0;
            }
        }
        Debug.Log($"Random : {n}");
        if (n == 1)
        {
            baby1.transform.position = new Vector3(-3, 0, 10);
            baby1.transform.rotation = Quaternion.Euler(0, 180, 0);

            baby1.SetActive(true);
            anim1.SetBool("getit", false);
            anim1.SetBool("dropit", false);
            anim1.SetBool("ButtonPush", false);

            //Instantiate(baby1, baby1.transform.position, Quaternion.identity);
        }
        if (n == 0)
        {
            baby2.transform.position = new Vector3(-3, 0, 10);
            baby2.transform.rotation = Quaternion.Euler(0, 90, 0);

            baby2.SetActive(true);
            baby2.GetComponent<Rotate>().enabled = true;
            anim2.SetBool("getit", false);
            anim2.SetBool("dropit", false);
            anim2.SetBool("ButtonPush", false);
            //Instantiate(baby2, baby2.transform.position, Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHIP_RED_SCRIPT : MonoBehaviour
{
    float Horizontal;

    float Vertical;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");

        Vertical = Input.GetAxis("Vertical");
 
    }
    void FixedUpdate()
    {
        transform.Translate(Horizontal * 0.25f,Vertical * 0.25f,0f);
        /*
        if(Horizontal > 0f){
            anim.SetBool("Ship-right",true);
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        
        if (Horizontal < 0f){
            anim.SetBool("Ship-right",true);
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }

        if (Horizontal == 0f){
            anim.SetBool("Ship-LEFT",false);
            anim.SetBool("Ship-right",false);
        }*/

    }
}

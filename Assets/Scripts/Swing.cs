using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{

    static Animator anim;

    //public float swingSpeed = 0.1f;

    //public float horizontal;
    //public float vertical;
    //public float stab;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //yeah
        //horizontal = Input.GetAxis("Fire1") * swingSpeed;
        //vertical = Input.GetAxis("Fire2") * swingSpeed;
        //stab = Input.GetAxis("Fire3") * swingSpeed;

        if(Input.GetButton("Fire1"))
        {
            anim.SetBool("isHAttacking", true);
        }
        else
            anim.SetBool("isHAttacking", false);

        if (Input.GetButton("Fire2"))
        {
            anim.SetBool("isVAttacking", true);
        }
        else
            anim.SetBool("isVAttacking", false);

        if (Input.GetButton("Fire3"))
        {
            anim.SetBool("isSAttacking", true);
        }
        else
            anim.SetBool("isSAttacking", false);
    }
}
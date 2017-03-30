using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwing : MonoBehaviour
{

    public Animator anim;
    public float attackTimer = 0;
    public float attackDelay = 2.2f;
    public float idleTimer = 0;
    public float idleDelay = 3;
    public bool swingFinished = false;

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

        //anim.SetBool("isHAttacking", false);
        attackTimer -= Time.deltaTime;
        if (!swingFinished)
        {
            anim.SetBool("isHAttacking", true);
            }
            if (swingFinished)
            {
                anim.SetBool("isHAttacking", false);
                idleTimer -= Time.deltaTime;
                if (idleTimer < 0)
                {
                    //swingFinished = false;
                }
        }
    }
}
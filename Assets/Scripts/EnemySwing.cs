using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwing : MonoBehaviour
{

    static Animator anim;
    public float attackTimer = 0;
    public float attackDelay = 2.2f;

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

        anim.SetBool("isHAttacking", false);
        attackTimer -= Time.deltaTime;
        if (attackTimer < 0)
        {
            attackTimer += attackDelay;
            anim.SetBool("isHAttacking", true);
        }
    }
}
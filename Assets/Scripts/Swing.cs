using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{

    public float swingSpeed = 0.1f;

    public float horizontal;
    public float vertical;
    public float stab;

	void Update ()
    {
        horizontal = Input.GetAxis("Fire1") * swingSpeed;
        vertical = Input.GetAxis("Fire2") * swingSpeed;
        stab = Input.GetAxis("Fire3") * swingSpeed;

        //transform.Translate(new Vector3(horizontal, stab, vertical));
        transform.Rotate(new Vector3(horizontal, stab, vertical));
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharMove : MonoBehaviour
{
    public GameObject camera;

    public float Force;
    public float JumpForce;

    public float sprint;
    private bool isSprint = false;

    public float xForce;
    public float yForce;
    public float jump;

    public bool canMove;
    public bool canSprint;

    public Slider StaminaSlider;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }
        canSprint = true;

        transform.rotation = Quaternion.Euler(0, camera.GetComponent<MouseLook>().currentYRotation, 0);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprint = true;
        }

        xForce = Input.GetAxis("Horizontal") * Force;
        yForce = Input.GetAxis("Vertical") * Force;
        jump = Input.GetAxis("Jump") * JumpForce;

        transform.Translate(new Vector3(0, jump, 0));


        if (isSprint != true)
        {
            transform.Translate(new Vector3(xForce, 0, yForce));
        }

        else
        {
            transform.Translate(new Vector3(xForce * sprint, 0, yForce * sprint));
            StaminaSlider.value -= .1f;
        }

        if (StaminaSlider.value == 0)
        {
            canSprint = false;
        }

        isSprint = false;
    }
}
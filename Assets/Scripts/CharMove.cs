using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharMove : MonoBehaviour
{
    public GameObject camera;

    public float Force;
    public float JumpForce;

    public float dash;
    private bool isSprint = false;

    public float xForce;
    public float yForce;
    public float jump;

    public bool canMove;
    public bool canDash;

    public Image Stamina;

    // Use this for initialization
    void Start()
    {
        Stamina = GameObject.FindGameObjectWithTag("sp").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }
        canDash = true;

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
            if (Stamina.fillAmount >= 20)
            { 
                transform.Translate(new Vector3(dash, 0, dash));
                Stamina.fillAmount -= 20f;
            }
        }

        if (Stamina.fillAmount < 200)
        {
            Stamina.fillAmount += .05f;
        }

        if (Stamina.fillAmount == 0)
        {
            canDash = false;
        }

        isSprint = false;
    }
}
using UnityEngine;
using System.Collections;

public class CharMove : MonoBehaviour
{
    public GameObject camera;

    public float Force;

    public float sprint;
    private bool isSprint = false;
    public float stamina = 50.0f;

    public float xForce;
    public float yForce;

    public bool canMove;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!canMove)
        {
            return;
        }

        transform.rotation = Quaternion.Euler(0, camera.GetComponent<MouseLook>().currentYRotation, 0);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprint = true;
        }

        xForce = Input.GetAxis("Horizontal") * Force;
        yForce = Input.GetAxis("Vertical") * Force;


        if(isSprint != true)
        {
            transform.Translate(new Vector3(xForce, 0, yForce));
        }
        
        else
        {
            transform.Translate(new Vector3(xForce * sprint, 0, yForce * sprint));
        }

        isSprint = false;
    }
}

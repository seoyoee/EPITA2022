using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public int hForce = 0;
    private float horizontal;

    private bool inputJump;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (!inputJump && isGrounded)
        {
            inputJump = Input.GetKeyDown(KeyCode.Space);
        }

        horizontal = Input.GetAxis("Horizontal");
        */
    }

    private void FixedUpdate()
    {
        /*if (inputJump && isGrounded)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            inputJump = false;
            isGrounded = false;
        }

        if (horizontal != 0)
        {
            rb.AddForce(Vector3.right * horizontal * 10, ForceMode.Acceleration);
        }*/
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}

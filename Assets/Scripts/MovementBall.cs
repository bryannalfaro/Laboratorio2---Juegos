using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBall : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump();
        }

    }

    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }
    }

    private void jump()
    {
        if (rb)
        {
            if (Mathf.Abs(rb.velocity.y) < 0.0005f)
            {
                rb.AddForce(0, force, 0, ForceMode.Impulse);
            }
        }
    }
}

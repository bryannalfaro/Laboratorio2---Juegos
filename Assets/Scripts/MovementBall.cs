using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBall : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 1.0f;
   
    int coins = 0;
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
            //Bola se mueve por fuerzas
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }
    }

    private void jump()
    {
        if (rb)
        {
            //Velocidad cercana a 0 para evitar saltos infinitos
            if (Mathf.Abs(rb.velocity.y) < 0.0005f)
            {
                rb.AddForce(0, force, 0, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
            if (coins < 1)
                Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ficha"))
            coins=coins+1;
            Destroy(other.gameObject);
    }



}

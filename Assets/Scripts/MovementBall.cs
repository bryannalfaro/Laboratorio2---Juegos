using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Bryann Alfaro
 * Clase donde se realiza la accion de la esfera
 * Referencia: Clase impartida
 */
public class MovementBall : MonoBehaviour
{
    private Rigidbody rb;
    public AudioClip coin_sound;
    
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
            MakeJump();
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

    private void MakeJump()
    {
        if (rb)
        {
            //Velocidad cercana a 0 para evitar saltos infinitos
            if (Mathf.Abs(rb.velocity.y) < 0.005f)
            {
                rb.AddForce(0, force, 0, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
            //Destruir si no ha comido ninguna moneda
            if (coins < 1) {
                
            Destroy(gameObject);
                
            }
                
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ficha"))
            coins=coins+1;
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(coin_sound);
        Destroy(other.gameObject);
    }



}

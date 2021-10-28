using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10.0f;
    public int playerPoints;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerPoints = 0;
    }

    void FixedUpdate()
    {
        // By default the Input.GetAxis is mapped to arrow keys and to aswd keys
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xAxis * speed, 0.0f, zAxis * speed);

        // Update position with an specified speed
        rb.AddForce(movement);
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "A_cyllinder") 
        {
            if (Input.GetKey(KeyCode.Space))
            {
            Debug.Log("A_cyllinder Collision Detected");
            Vector3 direction = collision.transform.position - transform.position;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(direction * 50.0f, ForceMode.Impulse);
            }  
        }
    }*/
}

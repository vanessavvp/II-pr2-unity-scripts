using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController : MonoBehaviour
{
    private Transform myTransform;
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // By default the Input.GetAxis is mapped to arrow keys and to aswd keys
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xAxis, 0, zAxis);

        // Update position per second and not per frame with an specified speed
        myTransform.position += movement * Time.deltaTime * speed;

        // Rotate the object
        if (Input.GetKey(KeyCode.Q)) {
            myTransform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.E)) {
            myTransform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
}

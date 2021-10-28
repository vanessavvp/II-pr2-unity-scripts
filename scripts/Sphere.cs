using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Rigidbody rb;
    float speed = 10f;
    Vector3 movement;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.I)) {
            movement = new Vector3(0.0f, 0.0f, 1.0f);
        } else if (Input.GetKey(KeyCode.L)) {
            movement = new Vector3(1.0f, 0.0f, 0.0f);
        } else if (Input.GetKey(KeyCode.M)) {
            movement = new Vector3(0.0f, 0.0f, -1.0f);
        } else if (Input.GetKey(KeyCode.J)) {
            movement = new Vector3(-1.0f, 0.0f, 0.0f);
        } else {
            movement = new Vector3(0.0f, 0.0f, 0.0f);
        }

        rb.position += movement * Time.deltaTime * speed;
    }
}

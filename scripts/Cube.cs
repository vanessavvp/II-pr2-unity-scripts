using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float distanceBetweenPlayer;
    float distanceBetweenSphere;
    public GameObject player;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        sphere = GameObject.FindGameObjectWithTag("Sphere");
    }

    // Update is called once per frame
    void Update() {
        distanceBetweenPlayer = Vector3.Distance(transform.position, player.transform.position);
        distanceBetweenSphere = Vector3.Distance(transform.position, sphere.transform.position);

        if (distanceBetweenPlayer <= 3f) {
            if (transform.localScale.x >= 1f)
            transform.localScale *= 0.3f;    
        }
        
        else if (distanceBetweenSphere <= 3f) {
            transform.localScale *= 1.005f;   
        }
    }
}

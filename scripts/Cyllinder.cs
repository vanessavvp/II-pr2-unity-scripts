using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyllinder : MonoBehaviour
{
    // Start is called before the first frame update
    float distanceBetweenObjects;
    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        distanceBetweenObjects = Vector3.Distance(transform.position, player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance <= 3f) {
            Vector3 cyllinderPos = new Vector3(transform.position.x, 0, transform.position.z);
            Vector3 playerPos = new Vector3(player.transform.position.x, 0, player.transform.position.z); 
            Vector3 direction = cyllinderPos - playerPos;  
            transform.Translate(direction * 3f * Time.deltaTime);    
        }    
    }
}

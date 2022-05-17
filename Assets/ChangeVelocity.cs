using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
public class ChangeVelocity : MonoBehaviour
{

    private Vector3 velocity;
    public Rigidbody rb;
    // public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        velocity = GameObject.Find("Player").GetComponent<teste>().velocity;        
    }

    void OnDetachedFromHand(Hand hand)
    {
        // print(velocity);
        

        rb.velocity += velocity;

    }
}

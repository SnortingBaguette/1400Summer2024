using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2000000f;
    Rigidbody rb;
    public float turnSpeed = 50f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();     //Get the Rigid body component attached to the object
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * 20 * forwardInput);        //test inputs using Translatiion
        //rb.AddForce(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        rb.AddRelativeForce(Vector3.forward * speed * Time.deltaTime * forwardInput);       //Inputs using physics forces
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);        //Rotate the car using the player input
    }
}

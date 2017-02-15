using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    float speedForce = 10f;
    float torqueForce = 2f;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().AddForce(transform.forward * speedForce); // adds force sending the vehicle forward
        
        float turn = Input.GetAxis("Horizontal"); // find the horizontal key binds
        rb.AddTorque(transform.up * torqueForce * turn);

    }

}


using UnityEngine;

public class Playermovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideMovement = 500f;
	// Use this for initialization
	
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d") )
        {
            rb.AddForce(sideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

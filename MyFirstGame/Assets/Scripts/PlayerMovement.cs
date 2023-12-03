using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 50f;
    public float sideForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            if (Input.GetKey("1"))
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
        
        
    }
}

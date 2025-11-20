using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    float jumpForce = 10f;
    bool isGrounded;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Jumping = new Vector3(0, jumpForce, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
                isGrounded = false;
                rb.AddForce(Jumping, ForceMode.Impulse);
            
        }
    }
}

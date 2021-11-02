using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_movment : MonoBehaviour
{
    public float UpAndDownSpeed;
    public float LeftAndRightSpeed;
    public float ForwardSpeed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.right * -ForwardSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * LeftAndRightSpeed * Time.deltaTime);
        }
       if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -LeftAndRightSpeed * Time.deltaTime);
        
        }
      else  if(Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.forward * -UpAndDownSpeed * Time.deltaTime);
        }
      else  if(Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.forward * UpAndDownSpeed * Time.deltaTime);
        }
        
      
      
    }
}

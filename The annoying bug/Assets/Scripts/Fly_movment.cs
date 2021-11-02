using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_movment : MonoBehaviour
{
    public float UpAndDownSpeed;
    public float LeftAndRightSpeed;
    public float ForwardSpeed;

    //Components
    Rigidbody rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //assagning component variables
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Forward velocity
         if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.right * -ForwardSpeed * Time.deltaTime);

            // Play animation
            anim.Play("Fly animation");

        }
         //Rotate Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * LeftAndRightSpeed * Time.deltaTime);

            // Freeze physics rotation
            rb.freezeRotation = true;

            // Play animation
            anim.Play("Fly animation");
        }
        //Rotate left
       if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -LeftAndRightSpeed * Time.deltaTime);

            // Freeze physics rotation
            rb.freezeRotation = true;

            // Play animation
            anim.Play("Fly animation");

        }
       //Rotate up
      else  if(Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.forward * -UpAndDownSpeed * Time.deltaTime);

            // Freeze physics rotation
            rb.freezeRotation = true;

            // Play animation
            anim.Play("Fly animation");
        }
       // rotate down
      else  if(Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.forward * UpAndDownSpeed * Time.deltaTime);

            // Freeze physics rotation
            rb.freezeRotation = true;

            // Play animation
            anim.Play("Fly animation");
        }

       else
        {
            //Start physics rotation
            rb.freezeRotation = false;
            
            
            
        }
        
      
      
    }
}

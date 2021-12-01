using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fly : MonoBehaviour
{
    //Speeds
    public float UpAndDownSpeed;
    public float LeftAndRightSpeed;
    public float ForwardSpeed;

    //other
    public bool IsStandingStill;


   bool IsmoovingForward;

   bool IsmoovingLeft;

   bool IsmoovingRight;

   bool IsmoovingUp;

   bool IsmoovingDown;

    public int Death_scene_number;


    //Component variables
    scene_manager scene;
    Animator anim;
    Rigidbody rb;
    AudioSource Audio;
    // Start is called before the first frame update

    private void Awake()
    {
        // Assagning the components to the component variables
        scene = FindObjectOfType<scene_manager>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();
    }
  

    // Update is called once per frame
    void Update()
    {
        IsFlyStandingStill();
        
        //Forward velocity
        if (Input.GetKey(KeyCode.Space))
        {
            

            rb.AddRelativeForce(Vector3.right * -ForwardSpeed * Time.deltaTime);

            

        }
         //Rotate Right
        if (Input.GetKey(KeyCode.D))
        {

         
            transform.Rotate(Vector3.up *  LeftAndRightSpeed * Time.deltaTime);

            
            // Freeze physics rotation
            rb.freezeRotation = true;
        }
        //Rotate left
       if(Input.GetKey(KeyCode.A))
        {
            

            transform.Rotate(Vector3.up * -LeftAndRightSpeed * Time.deltaTime);

            
            // Freeze physics rotation
            rb.freezeRotation = true;
        
        }
       //Rotate up
      else  if(Input.GetKey(KeyCode.W))
        {
            

            transform.Rotate(Vector3.forward * -UpAndDownSpeed * Time.deltaTime);

            
            // Freeze physics rotation
            rb.freezeRotation = true;
        }
       // rotate down
      else  if(Input.GetKey(KeyCode.S))
        {
            

            transform.Rotate(Vector3.forward * UpAndDownSpeed * Time.deltaTime);

           
            // Freeze physics rotation
            rb.freezeRotation = true;
        }

       else
        {

            

            //Start physics rotation
            rb.freezeRotation = false;
        }
        
      
      
    }

    public void IsFlyStandingStill()
    {
        IsmoovingForward = Input.GetKey(KeyCode.Space);

        IsmoovingLeft = Input.GetKey(KeyCode.A);

        IsmoovingRight = Input.GetKey(KeyCode.D);

        IsmoovingUp = Input.GetKey(KeyCode.W);

        IsmoovingDown = Input.GetKey(KeyCode.S);

       if(IsmoovingLeft || IsmoovingRight || IsmoovingUp || IsmoovingDown || IsmoovingForward)
        {
            IsStandingStill = false;
        }
       else
        {
            IsStandingStill = true;
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(Death_scene_number);
    }
}

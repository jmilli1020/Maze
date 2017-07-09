using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour {

 //   private Rigidbody rb;
 //   public float speed;

 //   void Start ()
 //   {
 //       rb = GetComponent<Rigidbody>();
	//}

 //   void FixedUpdate()
 //   {
 //       float moveHorizontal = Input.GetAxis("Horizontal");
 //       float moveVertical = Input.GetAxis("Vertical"); 

 //       Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
 //       rb.AddForce(movement * speed);
 //   }

     public float playerSpeed = 1000.0f;
     public float playerRotateSpeed = 100.0f;
 
   
    void Start ()
    {
        //player spawns here
       
        transform.position = new Vector3(80, (float)1.5, 65);
    }
   
    // Update is called once per frame
    void Update ()
    {
       
        transform.Rotate(Vector3.back * Input.GetAxis("Horizontal") * playerRotateSpeed * Time.deltaTime);
       
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
       
    }

}



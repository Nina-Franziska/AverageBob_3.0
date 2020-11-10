using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

[SerializeField]
float speed = 1.0f;

[SerializeField]
Rigidbody rb;


        public Vector3 jump;
         public float jumpForce = 2.0f;
     
         public bool isGrounded;
         void Start(){
      
             jump = new Vector3(0.0f, 2.0f, 0.0f);
         }
     
         void OnCollisionStay()
         {
             isGrounded = true;
             Debug.Log("er grounded");
         }
     
         void Update(){
             if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
     
                 rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                 isGrounded = false;
                 Debug.Log("hop");
             }
         }
    void FixedUpdate()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * speed;

        // Move translation along he object's z-axis
        transform.Translate(0, 0, translation);
        transform.Translate(rotation, 0, translation);

        // Rotate around our y-axis
       // transform.Rotate(0, rotation, 0);

       
    }
}


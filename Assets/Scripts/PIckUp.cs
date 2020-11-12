using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIckUp : MonoBehaviour
{
    [SerializeField]
    Transform hand;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       GameObject grabObj = collision.gameObject;

        if (Input.GetKeyDown(KeyCode.Space) && grabObj.CompareTag("Grab") )
        {
            grabObj.GetComponent<Collider>().enabled = false;
            grabObj.GetComponent<Rigidbody>().isKinematic = true;
            grabObj.GetComponent<Rigidbody>().useGravity = false;
            grabObj.transform.position = hand.position;
            grabObj.transform.parent = hand;
            
        }


        if (Input.GetKeyUp(KeyCode.Space) && grabObj.CompareTag("Grab"))
        {
            grabObj.transform.parent = null;
            grabObj.GetComponent<Collider>().enabled = true;
            grabObj.GetComponent<Rigidbody>().isKinematic = false;
            grabObj.GetComponent<Rigidbody>().useGravity = true;
      

        }



    }
}

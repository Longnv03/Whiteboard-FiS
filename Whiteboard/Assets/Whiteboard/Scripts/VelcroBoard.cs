using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelcroBoard : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Stick" tag
        if (collision.gameObject.CompareTag("Stick"))
        {
            // Optionally, set the object's position to the board's position at the contact point
            //Vector3 contactPoint = collision.GetContact(0).point;
            //collision.transform.position = contactPoint;

            // Make the object a child of the board to 'stick' it
            collision.transform.SetParent(transform);

            // Disable the Rigidbody if you want to prevent further physics interactions
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true;
            }
        }
    }



    /*
    void OnCollisionExit(Collision collision)
    {
        // Check if the object being released has the "Stick" tag
        if (collision.gameObject.CompareTag("Stick"))
        {
            // Remove the object from being a child of the board
            collision.transform.SetParent(null);

            // Re-enable the Rigidbody to allow for physics interactions again
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
              
            }
        }
    }
     */
}



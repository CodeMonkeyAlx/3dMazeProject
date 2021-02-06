using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //collision detection code.
    private void OnCollisionEnter(Collision other) 
    {
        /**
        First we log that a collision is detected.
        then we get the meshrenderer component the code is attached to and change
        color of the material to red. Using unity's built in color options.
        **/
        //Debug.Log("Ouch you hit a wall!");
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}

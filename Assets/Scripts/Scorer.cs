using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Score = 0;
    //collision detection code.
    private void OnCollisionEnter(Collision other) 
    {
        Score += 1;
        Debug.Log("You have bumped into something this many times: " + Score);
    }
}

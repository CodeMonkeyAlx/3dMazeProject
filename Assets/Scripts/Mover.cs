//Player movement script. Unity game dev course section 1.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    /**
    Serialize Fields can be used to modify variables directly within the unity editor. 
    Mega useful. These are also refered to as global variables. As they can be accessed 
    anywhere in the document and as many times as we like.
    **/  
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void PrintInstructions()
    {
        Debug.Log("Instructions:\n Use the direction buttons or WASD to move the ball to the goal");
        Debug.Log("Watch out for walls and obstacles though!");
        Debug.Log("....I just lost the game.");
    }

    void PlayerMovement()
    {
        //Access transform (Position) of the game object
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}

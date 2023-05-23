using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    //Added for Jump Feature
    public float jumpHeight = 350;
    // WORKING ON LEARNING HOW TO CREATE A JUMP ROBUST FEATURE
    //public float gravityScale = 5;

    //public float velocity;

    //public float floorHeight = 0.5f;
    //public Transform feet;
    //public ContactFilter2D filter;
    //public bool isGrounded = false;
    //public Collider2D[] results = new Collider2D[1];

    // increase speed when shift key is pressed
    public float shiftSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // for jump feature
        // velocity = Physics2D.gravity.y * gravityScale *Time.deltaTime;

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        // WORKING ON LEARNING HOW TO CREATE A JUMP ROBUST FEATURE
        //if (Physics2D.OverlapBox(feet.position, feet.localScale, 0, filter, results) > 0 && velocity < 0)
        //{
        //    velocity = 0;
        //    Vector2 surface = Physics2D.ClosestPoint(transform.position, results[0]) + Vector2.up * floorHeight;
        //    transform.position = new Vector3(transform.position.x, surface.y, transform.position.z);
        //    isGrounded = true;
        //}
        //else
        //{
        //    isGrounded= false;
        //}

        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    velocity = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * gravityScale));
        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, jumpHeight, 0) * Time.deltaTime );
        }
        
        // End Jump Feature

        // Increase spped and turning speed when the left shift key is pressed.
        if ( Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.forward * shiftSpeed * Time.deltaTime; ;
        }
    }
}

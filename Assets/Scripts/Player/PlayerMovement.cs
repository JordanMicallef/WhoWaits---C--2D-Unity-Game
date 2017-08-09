using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //variables that set the player movement speeds
    //Rigidbody2D body;
    //Animator anim;
    private float speed = 0.5f;
    private float terminalSpeed = 1.0f;
    private float acceleration = 0.2f;
    Vector3 movementDirection;
    //variables for box colliders, animator and sprites
    private BoxCollider2D boxCollider;
    private Animator anim;
    private Rigidbody2D body;
    private SpriteRenderer spriteRenderer;

    //sets the required player box variables
    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        movementDirection = Vector3.zero;
    }

	void Update ()
    {
        //Get axis raw returns true or false for these states, on/off states
        //input from keyboard press change these values
        movementDirection = new Vector3 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        if (speed < terminalSpeed)
        {
            speed += acceleration;
        }
        //moves the player accordingly to input above
        Vector3 newPosition = movementDirection * speed * Time.deltaTime;
        transform.position += newPosition;

        //depending on the movement direction, this changes the animation
        if (movementDirection != Vector3.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("input_x", movementDirection.x);
            anim.SetFloat("input_y", movementDirection.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
        } 
    }
    //functions that were used for a key press attack that was halted and changed

    //void FixedUpdate()
    //{
    //    AxeAttack();
    //}

    //private void AxeAttack()
    //{
    //    if (isAttacking)
    //    {
    //        anim.SetTrigger("attack");
    //    }
    //}

    //private void HandleInput()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        isAttacking = true;
    //    }
    //    else if (Input.GetMouseButtonUp(0))
    //    {
    //        isAttacking = false;
    //    }
    //}

    //if player collides with a weapon it sets the object to false
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
